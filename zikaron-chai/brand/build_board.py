import json, sys, pathlib


D = [
 {"n":1,"name":"ספיה קלאסית","en":"Sepia Classic","font":"Frank Ruhl Libre","w":900,
  "why":"חם, נוסטלגי, אמין. מרגיש כמו אלבום משפחתי.",
  "pal":[("#6B4226","חום ספיה"),("#C9A227","זהב עתיק"),("#F5ECDD","קרם"),("#2B2118","דיו כהה"),("#D9A79A","ורוד מעומעם")]},
 {"n":2,"name":"שעת זהב","en":"Golden Hour","font":"Suez One","w":400,
  "why":"אור שחוזר לתמונה. בולט ומקצועי, טוב לרשתות.",
  "pal":[("#1F2A44","כחול לילה"),("#E0A84B","זהב חם"),("#FAF3E6","שמנת"),("#C8664A","טרקוטה"),("#5E8C8A","טורקיז עמום")]},
 {"n":3,"name":"זית ופשתן","en":"Olive & Linen","font":"Bellefair","w":400,
  "why":"שורשים, משפחה ומורשת. רגוע ואלגנטי.",
  "pal":[("#5B6B3A","ירוק זית"),("#F3EEE3","פשתן"),("#8A5A3B","חום עץ"),("#D4A64A","זהב רך"),("#2E2E2A","פחם")]},
 {"n":4,"name":"סרט נע","en":"Film Reel","font":"Rubik","w":700,
  "why":"מודרני ושמח. משדר ׳תמונה שזזה׳, מתאים לטיקטוק.",
  "pal":[("#222222","פחם"),("#FBF7F0","לבן חם"),("#E8735A","קורל"),("#E3B341","חרדל"),("#7A9CB8","כחול מאובק")]},
 {"n":5,"name":"זיכרון רך","en":"Tender Memory","font":"Amatic SC","w":700,
  "why":"רגשי ועדין. מתאים במיוחד למתנות ולאזכרות.",
  "pal":[("#5A3E5D","שזיף"),("#C98B8B","ורוד עתיק"),("#FFF7EF","קרם חם"),("#9DB29A","מרווה"),("#C8A15A","זהב")]},
]

fams = "&".join("family="+d["font"].replace(" ","+")+":wght@400;700;900" if d["font"] in ("Frank Ruhl Libre","Rubik") else "family="+d["font"].replace(" ","+")+(":wght@400;700" if d["font"]=="Amatic SC" else "") for d in D)

def card(d):
    icon = pathlib.Path(f"icon_{d['n']}.svg")
    svg = icon.read_text() if icon.exists() else "<div style='width:100%;height:100%;background:#ddd'></div>"
    R={1:("#6B4226","#C9A227","#F5ECDD"),2:("#1F2A44","#E0A84B","#FAF3E6"),3:("#5B6B3A","#8A5A3B","#F3EEE3"),4:("#222222","#E8735A","#FBF7F0"),5:("#5A3E5D","#C98B8B","#FFF7EF")}
    dark, accent, light = R[d["n"]]
    sw = "".join(f"<div class='sw'><div class='chip' style='background:{h}'></div><b>{h}</b><span>{nm}</span></div>" for h,nm in d["pal"])
    return f"""
<section class='card'>
 <div class='hdr'><span class='num' style='background:{dark}'>{d['n']}</span><div><h2>{d['name']}</h2><p>{d['why']}</p></div></div>
 <div class='lock' style='background:{light}'>
   <div class='ic'>{svg}</div>
   <div class='wm' style='font-family:"{d['font']}";font-weight:{d['w']};color:{dark}'>זכרון חי<small style='color:{accent}'>תמונות ישנות חוזרות לחיים</small></div>
 </div>
 <div class='lock inv' style='background:{dark}'>
   <div class='ic sm'>{svg}</div>
   <div class='wm' style='font-family:"{d['font']}";font-weight:{d['w']};color:{light}'>זכרון חי</div>
 </div>
 <div class='pal'>{sw}</div>
</section>"""

html = f"""<!doctype html><html dir='rtl' lang='he'><head><meta charset='utf-8'>
<link href='https://fonts.googleapis.com/css2?{fams}&family=Heebo:wght@400;700&display=block' rel='stylesheet'>
<style>
body{{margin:0;background:#EFEBE4;font-family:Heebo,sans-serif;color:#222;width:1080px}}
.top{{padding:48px 56px 8px}} .top h1{{margin:0;font-size:54px}} .top p{{margin:8px 0 0;font-size:26px;color:#555}}
.card{{background:#fff;margin:36px 40px;border-radius:28px;padding:36px;box-shadow:0 6px 24px rgba(0,0,0,.08)}}
.hdr{{display:flex;gap:22px;align-items:center;margin-bottom:26px}}
.num{{color:#fff;font-size:44px;font-weight:700;width:76px;height:76px;border-radius:50%;display:flex;align-items:center;justify-content:center;flex:none}}
.hdr h2{{margin:0;font-size:42px}} .hdr p{{margin:4px 0 0;font-size:25px;color:#555}}
.lock{{display:flex;align-items:center;gap:34px;padding:34px 40px;border-radius:20px;margin-bottom:16px}}
.ic{{width:190px;height:190px;flex:none}} .ic.sm{{width:110px;height:110px}}
.ic svg{{width:100%;height:100%}}
.wm{{font-size:110px;line-height:1}} .inv .wm{{font-size:76px}}
.wm small{{display:block;font-family:Heebo;font-weight:400;font-size:28px;margin-top:14px;letter-spacing:.5px}}
.pal{{display:flex;gap:12px;margin-top:10px}}
.sw{{flex:1;text-align:center;font-size:20px}} .sw b{{display:block;font-size:19px;direction:ltr;margin-top:8px}} .sw span{{color:#666}}
.chip{{height:96px;border-radius:14px;border:1px solid rgba(0,0,0,.1)}}
</style></head><body>
<div class='top'><h1>זכרון חי · 5 כיוונים</h1><p>בחר מספר. אפשר גם לשלב: צבעים מכיוון אחד ולוגו מכיוון אחר.</p></div>
{''.join(card(d) for d in D)}
<div style='height:30px'></div></body></html>"""
pathlib.Path("board.html").write_text(html)
print("html ok")
