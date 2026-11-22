import sys, pathlib
icon = pathlib.Path(sys.argv[1]).read_text()
C = dict(char="#222222", white="#FBF7F0", coral="#E8735A", mustard="#E3B341", blue="#7A9CB8")
font = "Rubik"
head = f"""<!doctype html><html dir='rtl' lang='he'><head><meta charset='utf-8'>
<link href='https://fonts.googleapis.com/css2?family=Rubik:wght@400;700;900&family=Heebo:wght@400;700&display=block' rel='stylesheet'>
<style>body{{margin:0;background:#E9E5DE;font-family:Heebo,sans-serif;width:1080px}}
.blk{{margin:30px 40px;border-radius:26px;padding:44px;display:flex;align-items:center;gap:36px}}
.ic svg{{width:100%;height:100%}} .lbl{{font:700 24px Heebo;color:#555;margin:34px 44px -14px}}
.wm{{font-family:Rubik;font-weight:900;line-height:.95}} .tag{{font-family:Heebo;font-weight:400}}
</style></head><body>"""
body = f"""
<div class='lbl'>לוגו ראשי</div>
<div class='blk' style='background:{C['white']}'><div class='ic' style='width:220px;height:220px'>{icon}</div>
 <div><div class='wm' style='font-size:130px;color:{C['char']}'>זכרון חי</div><div class='tag' style='font-size:34px;color:{C['coral']};margin-top:16px'>תמונות ישנות חוזרות לחיים</div></div></div>
<div class='lbl'>על רקע כהה</div>
<div class='blk' style='background:{C['char']}'><div class='ic' style='width:220px;height:220px'>{icon}</div>
 <div><div class='wm' style='font-size:130px;color:{C['white']}'>זכרון חי</div><div class='tag' style='font-size:34px;color:{C['mustard']};margin-top:16px'>תמונות ישנות חוזרות לחיים</div></div></div>
<div class='lbl'>תמונת פרופיל (איך זה ייראה באינסטגרם ובטיקטוק)</div>
<div class='blk' style='background:#fff;justify-content:space-around'>
 <div style='width:300px;height:300px;border-radius:50%;background:{C['white']};display:flex;align-items:center;justify-content:center;box-shadow:0 0 0 2px #ddd'><div class='ic' style='width:230px;height:230px'>{icon}</div></div>
 <div style='width:300px;height:300px;border-radius:50%;background:{C['char']};display:flex;align-items:center;justify-content:center'><div class='ic' style='width:230px;height:230px'>{icon}</div></div>
 <div style='width:110px;height:110px;border-radius:50%;background:{C['white']};display:flex;align-items:center;justify-content:center;box-shadow:0 0 0 2px #ddd'><div class='ic' style='width:84px;height:84px'>{icon}</div></div>
</div>
<div class='lbl'>צבעים</div>
<div class='blk' style='background:#fff;gap:14px'>""" + "".join(
 f"<div style='flex:1;text-align:center;font:700 20px Heebo'><div style='height:110px;border-radius:14px;background:{h};border:1px solid #0001'></div><div style='direction:ltr;margin-top:8px'>{h}</div><div style='font-weight:400;color:#666'>{n}</div></div>"
 for h,n in [(C['coral'],'קורל (ראשי)'),(C['char'],'פחם'),(C['mustard'],'חרדל'),(C['white'],'לבן חם'),(C['blue'],'כחול מאובק')]) + """</div>
<div class='lbl'>פונטים: Rubik Black לכותרות · Heebo לטקסט</div><div style='height:40px'></div></body></html>"""
pathlib.Path("final_kit.html").write_text(head+body)
# profile picture standalone
pp = f"""<!doctype html><html><head><meta charset='utf-8'><style>body{{margin:0}}</style></head><body>
<div style='width:1080px;height:1080px;background:{C['white']};display:flex;align-items:center;justify-content:center'><div style='width:820px;height:820px'>{icon}</div></div></body></html>"""
pathlib.Path("profile.html").write_text(pp)
print("ok")
