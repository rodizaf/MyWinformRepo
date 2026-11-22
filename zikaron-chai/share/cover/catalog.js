const { chromium } = require('playwright'); const fs = require('fs');
const logo = fs.readFileSync('../../brand/logo_icon.svg','utf8');
const items = [
 {f:'catalog_1_moment.jpg', name:'רגע אחד', price:'49 ₪', sub:'תמונה אחת שחוזרת לחיים', grid:['a.png'], cols:1},
 {f:'catalog_2_family.jpg', name:'המשפחתית', price:'149 ₪', sub:'5 תמונות וסרטון מונטאז׳', grid:['e.png','b.png','c.png','d.png'], cols:2},
 {f:'catalog_3_album.jpg', name:'אלבום זיכרון', price:'249 ₪', sub:'10 תמונות וסרטון עם שמות ותאריכים', grid:['a.png','b.png','c.png','d.png','e.png','f.png','g.png','a.png','c.png'], cols:3},
];
(async () => { const b = await chromium.launch(); const p = await b.newPage({ viewport: { width: 1080, height: 1080 } });
 for (const it of items) {
  const cells = it.grid.map(s => `<div style="background-image:url(${s})"></div>`).join('');
  const html = `<!doctype html><html dir="rtl"><head><meta charset="utf-8"><link href="https://fonts.googleapis.com/css2?family=Rubik:wght@900&family=Heebo:wght@500;700&display=block" rel="stylesheet"><style>
  body{margin:0;width:1080px;height:1080px;background:#FBF7F0;font-family:Heebo;position:relative;overflow:hidden}
  .g{position:absolute;inset:0 0 300px 0;display:grid;grid-template-columns:repeat(${it.cols},1fr);gap:6px}.g div{background-size:cover;background-position:center 25%}
  .bar{position:absolute;left:0;right:0;bottom:0;height:300px;display:flex;align-items:center;gap:28px;padding:0 56px;box-sizing:border-box}
  .ic{width:150px;height:150px;flex:none}.ic svg{width:100%;height:100%}.t{flex:1}
  h1{font:900 82px/1 Rubik;color:#222;margin:0}p{font:700 38px Heebo;color:#55504A;margin:10px 0 0}
  .pr{font:900 84px Rubik;color:#222;background:#E8735A;border-radius:28px;padding:10px 30px;flex:none}
  </style></head><body><div class="g">${cells}</div><div class="bar"><div class="ic">${logo}</div><div class="t"><h1>${it.name}</h1><p>${it.sub}</p></div><div class="pr">${it.price}</div></div></body></html>`;
  fs.writeFileSync('cat_tmp.html', html); await p.goto('file://' + require('path').resolve('cat_tmp.html')); await p.waitForTimeout(2200);
  await p.screenshot({ path: `../${it.f}`, type: 'jpeg', quality: 88 }); }
 await b.close(); })();
