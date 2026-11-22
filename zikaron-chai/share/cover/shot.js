const { chromium } = require('playwright');
(async () => { const b = await chromium.launch(); const p = await b.newPage({ viewport: { width: 1640, height: 624 } });
 await p.goto('file://' + require('path').resolve('cover.html')); await p.waitForTimeout(2500);
 await p.screenshot({ path: '../facebook_cover.jpg', type: 'jpeg', quality: 90 }); await b.close(); })();
