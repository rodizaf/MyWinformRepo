const { chromium } = require('playwright');
(async () => { const b = await chromium.launch(); const p = await b.newPage({ viewport: { width: 1080, height: 3000 } });
 await p.goto('file://' + require('path').resolve('overlays.html')); await p.waitForTimeout(2500);
 await (await p.$('#wm')).screenshot({ path: 'watermark.png', omitBackground: true });
 await (await p.$('#end')).screenshot({ path: 'endcard.png' }); await b.close(); })();
