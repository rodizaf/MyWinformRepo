const { chromium } = require('playwright');
(async () => {
  const [,, inFile, outFile, w] = process.argv;
  const b = await chromium.launch(); const p = await b.newPage({ viewport: { width: +w || 1080, height: 1000 }, deviceScaleFactor: 1 });
  await p.goto('file://' + require('path').resolve(inFile)); await p.waitForTimeout(3000);
  await p.screenshot({ path: outFile, fullPage: true }); await b.close();
})();
