#!/usr/bin/env bash
# Usage:
#   ./deliver.sh preview <input.mp4> <out.mp4>   -> 540p, diagonal watermark (free preview for the customer)
#   ./deliver.sh final   <input.mp4> <out.mp4>   -> clean full quality + 2s branded end card
set -euo pipefail
cd "$(dirname "$0")"
mode="$1"; in="$2"; out="$3"
W=$(ffprobe -v error -select_streams v:0 -show_entries stream=width -of csv=p=0 "$in")
H=$(ffprobe -v error -select_streams v:0 -show_entries stream=height -of csv=p=0 "$in")
if [ "$mode" = "preview" ]; then
  ffmpeg -v error -y -i "$in" -i watermark.png -filter_complex \
    "[0:v]scale=-2:540[v];[1:v]scale=w='min(iw,540*${W}/${H})':h=-1[wm];[v][wm]overlay=(W-w)/2:(H-h)/2,format=yuv420p" \
    -an -c:v libx264 -crf 28 -preset medium -movflags +faststart "$out"
elif [ "$mode" = "final" ]; then
  fps=$(ffprobe -v error -select_streams v:0 -show_entries stream=r_frame_rate -of csv=p=0 "$in")
  ffmpeg -v error -y -i "$in" -loop 1 -t 2 -i endcard.png -filter_complex \
    "[0:v]fps=${fps},scale=${W}:${H},setsar=1,format=yuv420p[a];[1:v]scale=${W}:${H}:force_original_aspect_ratio=decrease,pad=${W}:${H}:(ow-iw)/2:(oh-ih)/2:color=0xFBF7F0,fps=${fps},setsar=1,format=yuv420p[e];[a][e]xfade=transition=fade:duration=0.5:offset=$(ffprobe -v error -show_entries format=duration -of csv=p=0 "$in" | awk '{print $1-0.5}')[o]" \
    -map "[o]" -an -c:v libx264 -crf 20 -preset medium -movflags +faststart "$out"
else
  echo "mode must be preview or final"; exit 1
fi
echo "ok: $out"
