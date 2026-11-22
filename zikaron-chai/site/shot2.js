const { chromium } = require('playwright');
(async () => { const b = await chromium.launch(); const p = await b.newPage({ viewport: { width: 1200, height: 630 } });
 await p.goto('file://' + require('path').resolve('og.html')); await p.waitForTimeout(2500);
 await p.screenshot({ path: 'og.jpg', type: 'jpeg', quality: 86 }); await b.close(); })();
