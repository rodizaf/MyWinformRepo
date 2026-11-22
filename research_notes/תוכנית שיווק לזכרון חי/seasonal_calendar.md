# Seasonal and Holiday Calendar, 1 Dec 2026 to 31 May 2027, for Zikaron Chai (זכרון חי)

Research date: 22 Nov 2026. Scope: the dates in Israel, why each matters for an AI photo-restoration and "memory video" gift brand (49-249 ILS, digital delivery over WhatsApp within about 24-48h), the angle and tone for each, lead times, and sensitivity rules. Audiences: Hebrew-speaking Israelis, Israeli Russian speakers, English-speaking diaspora.

How the dates were checked. hebcal.com, chabad.org, israelhayom.co.il and other sites could not be fetched directly: this session's network blocks those hosts, so they would have to be allowed in the session's network settings for a direct check. Jewish dates were therefore checked two ways:
- (a) Search-result snippets that quote hebcal.com and chabad.org pages.
- (b) A local calculation with the open-source Hebrew-calendar library `pyluach` 2.3.0 in Israel mode, plus `python-dateutil` for Easter. The calculation also gives the weekday for every date.

Where only (b) supports a date, the table says "computed". Every Jewish date starts at sundown the evening before the Gregorian date shown.

---

## 1. Verified master calendar (Gregorian dates, Israel)

### Takeaway
5787 (2026-27) is a Hebrew leap year, with Adar I and Adar II. That pushes Purim to 23 Mar 2027 and Pesach to 22 Apr 2027. All of Israel's memorial and national days therefore fall in one tight run, 3-12 May 2027, which also contains Victory Day and US Mother's Day (both Sun 9 May). That run is the most sensitive stretch of the period.

### Cited Findings
- Hanukkah 5787 starts at sundown on Fri 4 Dec 2026 and ends at nightfall on Sat 12 Dec 2026. The first candle is lit Friday before sundown and before the Shabbat candles. — [hebcal Chanukah 2026](https://www.hebcal.com/holidays/hanukkah-2026); [Chabad Chanukah](https://www.chabad.org/holidays/chanukah/); [Chabad printable guide 2026](https://www.chabad.org/holidays/chanukah/article_cdo/aid/789752/jewish/Printable-Chanukah-Guide-2026.htm)
- Purim 2027 is Tue 23 Mar. Ta'anit Esther and Erev Purim are Mon 22 Mar, and Shushan Purim (Jerusalem) is Wed 24 Mar. Erev Pesach is Wed 21 Apr 2027, Pesach I is Thu 22 Apr, and Pesach VIII (diaspora) is Thu 29 Apr. Yom HaShoah is Tue 4 May 2027, starting at sundown on Mon 3 May. — [hebcal Jewish Holidays 2027 (Israel)](https://www.hebcal.com/holidays/2027?i=on); [hebcal 2026-2027](https://www.hebcal.com/holidays/2026-2027?i=on); [USC Jewish holy days calendar](https://orsl.usc.edu/life/jewish-holy-days-calendar/)
- Yom HaZikaron 2027 is 4 Iyar 5787 and Yom HaAtzma'ut is 5 Iyar 5787. A school calendar maps them to 11 May and 12 May 2027. One aggregator (calendarlabs) gives 10 May, which appears to be wrong, since 4 Iyar works out to Tue 11 May. — [hebcal Yom HaZikaron 2027](https://www.hebcal.com/holidays/yom-hazikaron-2027); [hebcal Yom HaAtzma'ut 2027](https://www.hebcal.com/holidays/yom-haatzmaut-2027); [Shalhevet calendar](https://www.shalhevet.org/apps/events/44701310/); conflicting: [calendarlabs](https://www.calendarlabs.com/holidays/jewish/yom-hazikaron.php)
- Family Day (יום המשפחה) 2027 is 30 Shevat 5787, which is Sun 7 Feb 2027. — [hebcal Family Day 2027](https://www.hebcal.com/holidays/family-day-2027?i=on); [amhazak Family Day](https://www.amhazak.com/holidays/family-day)
- 5787 is a leap year. Computed dates in Israel mode (pyluach):
  - Tu BiShvat: Sat 23 Jan 2027 (15 Shevat).
  - 30 Shevat: Sun 7 Feb 2027.
  - Purim Katan: Sun 21 Feb 2027.
  - 10 Tevet fast: Sun 20 Dec 2026.
  - 7th day of Pesach (end of Pesach in Israel): Wed 28 Apr 2027.
  - Pesach Sheni: Fri 21 May 2027.
  - Lag BaOmer: Tue 25 May 2027 (18 Iyar).
  - Shavuot: Fri 11 Jun 2027 (6 Sivan).
  - Tu B'Av: Wed 18 Aug 2027 (15 Av).
  - These match the hebcal and Chabad snippets wherever both exist (Hanukkah, Purim, Pesach). — computed locally; cross-check source [hebcal 2026-2027](https://www.hebcal.com/holidays/2026-2027?i=on)
- Christian dates, computed with dateutil: Western Easter is Sun 28 Mar 2027 and Orthodox Easter is Sun 2 May 2027. UK Mothering Sunday is Easter minus 21 days, so Sun 7 Mar 2027. US, Canada and Australia Mother's Day (2nd Sunday of May) is Sun 9 May 2027. Russian Mother's Day (last Sunday of November) is Sun 29 Nov 2026, just before this period. — computed locally (no web source fetched)

### Master table (all dates verified or computed as noted)

| Date (weekday) | Occasion | Starts evening before? | Audience | Priority for sales | Verification |
|---|---|---|---|---|---|
| Fri 4 Dec - Sat 12 Dec 2026 | Hanukkah (1st candle Fri 4 Dec before Shabbat; 8th candle Fri 11 Dec) | Yes, 1st night is Fri 4 Dec | HE, RU, EN | HIGH | hebcal + Chabad |
| Sun 6 - Sat 12 Dec 2026 | School Hanukkah break (approx.) | - | HE families | context | secondary source only |
| Sun 20 Dec 2026 | 10 Tevet fast, also General Kaddish Day | Fast is daytime | HE religious | avoid celebratory push | computed; Kaddish-day status not verified this session |
| Fri 25 Dec 2026 | Christmas | Eve Thu 24 Dec | EN (interfaith), small RU segment | MEDIUM (EN) | fixed date |
| Thu 31 Dec 2026 -> Fri 1 Jan 2027 | Novy God / New Year's Eve | Celebrated night of 31 Dec | RU (very high), HE/EN secondary | HIGH (RU) | fixed date |
| Thu 7 Jan 2027 | Orthodox Christmas | Eve 6 Jan | small RU segment | LOW | fixed date (Julian calendar) |
| Night Wed 13 -> Thu 14 Jan 2027 | Old New Year (Staryi Novyi God) | Night of 13 Jan | RU | LOW-MEDIUM | fixed date |
| Sat 23 Jan 2027 | Tu BiShvat | Eve Fri 22 Jan | HE | content only | computed |
| Wed 27 Jan 2027 | International Holocaust Remembrance Day (UN) | - | EN diaspora | NO SALES | fixed date |
| Sun 7 Feb 2027 | Family Day (30 Shevat) | Eve Sat 6 Feb | HE (main), RU | HIGH | hebcal + amhazak |
| Sun 14 Feb 2027 | Valentine's Day | - | HE, RU, EN | MEDIUM-HIGH | fixed date |
| Tue 23 Feb 2027 | Defender of the Fatherland Day ("men's day") | - | RU | optional | fixed date; Israeli salience not verified |
| Sun 7 Mar 2027 | UK Mothering Sunday | - | EN (UK) | MEDIUM (UK) | computed |
| Mon 8 Mar 2027 | International Women's Day | - | RU (very high), HE | HIGH (RU) | fixed date |
| Tue 23 Mar 2027 (Shushan Purim Wed 24 Mar, Jerusalem) | Purim | Eve Mon 22 Mar (Megillah) | HE | LOW-MEDIUM | hebcal |
| Sun 28 Mar 2027 | Western Easter | - | EN interfaith | LOW | computed |
| Wed 21 Apr 2027 (Seder night); Thu 22 - Wed 28 Apr | Pesach | Seder is the evening of Wed 21 Apr | HE, RU, EN | HIGH (top family gathering) | hebcal |
| ~Tue 13 - Wed 28 Apr 2027 | School Pesach break (approx.; school resumes Thu 29 Apr) | - | HE families | context | secondary sources only |
| Night Wed 28 -> Thu 29 Apr 2027 | Mimouna | Evening after Pesach ends | HE (North African heritage) | LOW | computed from Pesach end |
| Sun 2 May 2027 | Orthodox Easter | - | small RU segment | LOW | computed |
| Mon 3 May (eve) - Tue 4 May 2027 | Yom HaShoah | Yes, Mon 3 May evening | All | NO SALES / PAUSE | hebcal + USC |
| Sun 9 May 2027 | Victory Day over Nazi Germany (Israeli state law) | - | RU (very high) | commemorative, soft | law cited below; date not moved in 2027 (inferred) |
| Sun 9 May 2027 | Mother's Day (US/Canada/Australia) | - | EN | HIGH (EN) | computed |
| Mon 10 May (eve, 20:00) - Tue 11 May 2027 | Yom HaZikaron | Yes, Mon 10 May evening | All | NO SALES / PAUSE | hebcal + Shalhevet |
| Tue 11 May (eve) - Wed 12 May 2027 | Yom HaAtzmaut | Yes, Tue 11 May evening | HE, RU, EN | soft/celebratory | hebcal + Shalhevet |
| Mon 24 May (eve) - Tue 25 May 2027 | Lag BaOmer, opening of wedding season | Yes, Mon 24 May evening | HE | MEDIUM (weddings) | computed |
| Fri 4 Jun 2027 (outside range) | Yom Yerushalayim (28 Iyar) | Eve Thu 3 Jun | HE | n/a | computed |
| Fri 11 Jun 2027 (outside range) | Shavuot | Eve Thu 10 Jun | HE | n/a (lead-in late May) | computed |
| Wed 18 Aug 2027 (outside range) | Tu B'Av | Eve Tue 17 Aug | HE | n/a | computed |

### Inferences
- In a leap year Pesach comes late, so Yom HaShoah (4 May), Victory Day and US Mother's Day (9 May), Yom HaZikaron (11 May) and Yom HaAtzmaut (12 May) all sit inside 10 days. Plan the whole of May as one carefully sequenced block, not separate campaigns.
- Shabbat falls on or next to several key dates: the 1st and 8th nights of Hanukkah are Fridays, Tu BiShvat is a Saturday, Family Day eve is Saturday night. If the studio does not produce or deliver on Shabbat, the practical last order date moves one day earlier. Religious customers may also not want WhatsApp deliveries on Shabbat or Yom Tov.
- These are not in the requested list but sit just before the period: Black Friday (Fri 27 Nov 2026, the day after US Thanksgiving on Thu 26 Nov), Russian Mother's Day (Sun 29 Nov 2026) and Cyber Monday (30 Nov 2026). They overlap with the start of the Hanukkah push and can be used as a "pre-Hanukkah" launch.

### Gaps
- hebcal.com and chabad.org could not be opened directly (network blocked), so some dates rest on search snippets plus the local calculation, not a full page read. The dates marked "computed" (Tu BiShvat, Lag BaOmer, Shavuot, 10 Tevet, Tu B'Av, Purim Katan) were not seen on a hebcal page in this session.
- The official Ministry of Education 5787 vacation circular was not retrieved. The school break dates (Hanukkah from Sun 6 Dec, Pesach about 6-21 Nisan with return on Thu 29 Apr) come from a community-centre PDF and a consumer guide: [rng.org.il](https://rng.org.il/uploads/n/1785678884.5499.pdf), [Israel Hayom vacation calendar](https://www.israelhayom.co.il/vacation-calendar), [MoE daycare calendar](https://meyda.education.gov.il/files/PreSchool/maonot/haredi2026-2027.pdf).
- Whether the government will move Victory Day 2027 by decision was not confirmed. The law allows a move when 9 May falls on a holiday, Shabbat or memorial day, or on the day before one. 9 May 2027 is a Sunday two days before Yom HaZikaron, so it is probably not moved (inference).

---

## 2. December 2026: Hanukkah, Christmas, Novy God, Old New Year

### Takeaway
December is the most commercially important month and the clock is already running: the first candle is 12 days away (4 Dec). After Hanukkah (from 13 Dec) the focus should switch to Russian-language Novy God (31 Dec), which is the main family gift-and-nostalgia occasion for Israeli Russian speakers.

### Cited Findings
- Hanukkah runs from sundown Fri 4 Dec to nightfall Sat 12 Dec 2026. — [hebcal](https://www.hebcal.com/holidays/hanukkah-2026); [Chabad](https://www.chabad.org/holidays/chanukah/)
- Novy God arrived in Israel with the early-1990s immigration from the former USSR. It is a secular, civic New Year holiday centred on family: a big family meal, a decorated "yolka" tree, Ded Moroz and Snegurochka, presents, Soviet-era songs, and "summing up the year that passed and wishing loved ones well". — [ISRAEL21c, Celebrating tradition at Novy God](https://archive.israel21c.org/celebrating-novy-god-the-russian-new-year-holiday-in-israel/); [JTA 2015](https://www.jta.org/2015/12/21/israel/russian-israelis-embrace-tinsel-trees-and-santa-claus-but-dont-call-it-christmas)
- Some Israelis have objected to Novy God as Christian or un-Jewish. Supporters reply that it only marks the start of the civil year. A 2015 "Israeli Novy God" campaign encouraged Russian-speaking families to host native Israelis, and the holiday has been spreading beyond the community. — [ISRAEL21c](https://archive.israel21c.org/celebrating-novy-god-the-russian-new-year-holiday-in-israel/); [ynetnews: 'Not Christian'](https://www.ynetnews.com/jewish-world/article/hyuntyxnbg); [JPost: Novy God is no longer a holiday for the few](https://www.jpost.com/Opinion/Novy-God-is-no-longer-a-holiday-for-the-few-612589)
- Academic work describes Novy God as a "homeland holiday" that anchors immigrant identity and is being reinvented by the "1.5 generation" (people who immigrated as children). — [Bar-Ilan: Homeland holidays as anchors of immigrant identity](https://cris.biu.ac.il/en/publications/homeland-holidays-as-anchors-of-immigrant-identity-new-year-novy-/)
- The school Hanukkah break reportedly runs from Sun 6 Dec 2026 (26 Kislev) through 2 Tevet. — [rng.org.il calendar](https://rng.org.il/uploads/n/1785678884.5499.pdf) (secondary)

### Inferences (recommended actions)
- **Hanukkah (HE main, also RU/EN)**
  - Why it fits: eight nights of family visits, grandparents present, gift-giving to children and grandparents. A restored photo of grandparents lighting candles, or of a parent as a child at a Hanukkah party, animated, makes a natural "gift for the whole family".
  - Angle: "האור של המשפחה" (the family's light): bring back the faces from old Hanukkah albums. One candle a night, one memory a night: an 8-night social series with an 8-night offer or a daily draw.
  - Tone: warm, festive, nostalgic, not heavy.
  - Timing: start now (23 Nov). Peak 29 Nov to 9 Dec.
  - Last order: to have the video at the 1st candle (Fri 4 Dec, before Shabbat), absolute last order Wed 2 Dec, safe Tue 1 Dec. For any later night up to the 8th candle (Fri 11 Dec), absolute last order Wed 9 Dec. Push "last nights" urgency on 7-9 Dec.
  - Sensitivity: low. Keep Shabbat (4-5 Dec, 11-12 Dec) in mind for posting and delivery to religious customers.
- **10 Tevet, Sun 20 Dec**: a minor fast. It is also widely known as the General Kaddish Day for victims whose date of death is unknown, many of them Holocaust victims (this status was not verified in this session). Avoid loud promotions that day. A respectful note is optional.
- **Christmas, Fri 25 Dec (EN; small RU segment)**
  - Context: most English-speaking diaspora Jews give Hanukkah gifts (early this year, 4-12 Dec). Christmas matters for interfaith families and non-Jewish relatives.
  - Angle: "a gift that travels across oceans in minutes", grandparents abroad.
  - Timing: English ads 1-23 Dec. Last order Wed 23 Dec (safe Tue 22 Dec), using Israeli production time and allowing for US/UK time zones.
  - Keep Christmas imagery out of the Hebrew channels.
- **Novy God, night of Thu 31 Dec (RU top priority)**
  - Why it fits: a family holiday about summing up the year and wishing loved ones well, which suits "memory" videos. Soviet-era photos of children by the New Year's tree are a classic family-album genre in post-Soviet families (inference from the yolka custom; not separately sourced).
  - Angle: "Оживите семейный альбом к Новому году" (bring the family album to life for New Year): grandma and grandpa "come alive" in a New Year greeting video sent to the family WhatsApp group at midnight.
  - Tone: warm, nostalgic, celebratory. Russian language and Russian cultural references.
  - Framing: say "Новый год" / "New Year", not Christmas, to respect the religious debate. For Hebrew audiences use "נובי גוד" (Novy God) or "ראש השנה האזרחי" (the civil New Year), without crosses or nativity imagery.
  - Timing: soft start 1 Dec in Russian channels, main push 13-29 Dec.
  - Last order: absolute Tue 29 Dec, safe Mon 28 Dec. Expect a volume peak.
  - Optional: a "family year-in-review" product bundling 2026 photos with old ones.
- **Orthodox Christmas, Thu 7 Jan**: niche (non-Jewish family members of immigrants). Do not run a dedicated campaign.
- **Old New Year, night of Wed 13 Jan**
  - Use it as a "second chance" for anyone who missed Novy God. Light Russian-language push 4-11 Jan.
  - Last order: absolute Mon 11 Jan, safe Sun 10 Jan.

### Gaps
- No reliable Israeli source was found giving the size of Novy God gift spending or how far ahead Russian-speaking Israelis buy New Year gifts.
- The General Kaddish Day status of 10 Tevet comes from general knowledge, not a source fetched in this session.

---

## 3. January to February 2027: Tu BiShvat, Family Day, Valentine's Day (and Tu B'Av note)

### Takeaway
Family Day (Sun 7 Feb) is the best Hebrew-market fit of the winter. It is Israel's replacement for Mother's Day and is about honouring family, which is exactly the product. Running it back to back with Valentine's Day (Sun 14 Feb) gives a two-week February campaign. Tu BiShvat (Sat 23 Jan) is for content (roots and family tree), not sales.

### Cited Findings
- Family Day 2027 is 30 Shevat 5787, Sun 7 Feb 2027. — [hebcal](https://www.hebcal.com/holidays/family-day-2027?i=on); [amhazak](https://www.amhazak.com/holidays/family-day)
- Israel's Mother's Day was set on the yahrzeit (death anniversary) of Henrietta Szold, known as the "mother of Youth Aliyah", who had no children of her own. Szold died on 30 Shevat. The day was later renamed Family Day. JTA says the renaming came in the 1980s after pressure from some feminists. A Jerusalem Post piece names Rosh Chodesh Adar, which is the same day, since 30 Shevat is the first day of Rosh Chodesh Adar. — [JTA: How Mother's Day came to Israel](https://jta.org/jewniverse/2014/how-mothers-day-came-to-israel); [Kipa column](https://www.kipa.co.il/הורים-וילדים/1152101-0); [JPost: What happened to Mother's Day?](https://www.jpost.com/opinion/the-human-spirit-what-happened-to-mothers-day-445346); [amhazak](https://www.amhazak.com/holidays/family-day)
- The idea of an Israeli Mother's Day was proposed on 14 Nov 1951 by an 11-year-old girl, Nechama Frankel, in the children's paper "Haaretz Shelanu". — [JTA](https://jta.org/jewniverse/2014/how-mothers-day-came-to-israel)
- Tu BiShvat 2027 is Sat 23 Jan (eve Fri 22 Jan). — computed (pyluach)
- Tu B'Av 2027 is Wed 18 Aug (eve Tue 17 Aug), outside the period. — computed (pyluach)

### Inferences (recommended actions)
- **Tu BiShvat, Sat 23 Jan (eve Fri 22 Jan)**
  - Angle: "שורשים" (roots) and "אילן יוחסין" (family tree). Content posts such as "the tree our family grew from", tied to the 7th-grade roots project (section 7).
  - Tone: light, educational.
  - Timing: 17-22 Jan. No hard sell, and nothing on Shabbat.
- **International Holocaust Remembrance Day, Wed 27 Jan (EN diaspora)**: pause English-language promotions. A respectful candle post is optional. Do not use survivor or victim photos in promotions (see section 6).
- **Family Day, Sun 7 Feb (HE primary; RU and EN secondary)**
  - Why it fits: kindergartens and schools mark it, and it is about honouring parents, grandparents and family. Some families still treat it as "Mother's Day" (inference, from its origin).
  - Angle: "יום המשפחה: המשפחה שלכם, בתנועה" (Family Day: your family, in motion). Show three or four generations together, for example great-grandma's wedding photo animated beside the grandchildren.
  - Tone: warm, inclusive. Do not assume a two-parent family.
  - Timing: start Sun 24 Jan, peak 31 Jan to 5 Feb.
  - Last order: the target is Sun 7 Feb morning and Saturday sits in between, so absolute last order Fri 5 Feb (if the studio works Saturday) or Thu 4 Feb (if not). Communicate Thu 4 Feb.
- **Valentine's Day, Sun 14 Feb (HE, RU, EN)**
  - Angle: couples, especially parents' or grandparents' wedding photos animated as an anniversary or "love story" gift ("איך הכל התחיל", how it all began). This differs from typical Valentine's products and suits a memory brand.
  - Tone: romantic and tender. Avoid kitsch.
  - Timing: 8-12 Feb, right after Family Day.
  - Last order: absolute Fri 12 Feb, safe Thu 11 Feb (Shabbat in between).
- **Purim Katan, Sun 21 Feb**: not relevant.
- **Defender of the Fatherland Day, Tue 23 Feb (RU)**: in post-Soviet culture it works as a "men's day" for fathers and grandfathers. It could carry an optional small Russian-language "for dad or grandpa" post. Low priority and not verified for Israel.
- **Tu B'Av, Wed 18 Aug 2027**: outside the period. Mention it only as the Israeli "love day" to plan for later in the year; the couples angle above can be reused then.

### Gaps
- No source quantified Israeli spending on Family Day or Valentine's Day, or how widely Israelis celebrate Valentine's next to Tu B'Av.
- Exact kindergarten and school practice for Family Day when it falls on a Sunday (events that day or the week before) was not verified.

---

## 4. March 2027: Mothering Sunday (UK), International Women's Day, Purim

### Takeaway
International Women's Day (Mon 8 Mar) is a major gift occasion for Israeli Russian speakers: flowers and gifts for mothers, grandmothers, wives and colleagues. It should be the main March campaign, in Russian. It falls the day after UK Mothering Sunday (Sun 7 Mar), so one "honour the women of the family" creative can serve both RU and EN-UK. Purim (Tue 23 Mar) is a low-priority content moment.

### Cited Findings
- Israeli retailers run 8 March promotions aimed at Russian speakers. Jack Kuba launched an 8 March gift collection from 99 ILS and presented it to Russian-speaking journalists and bloggers (2016). The Shefa Teamim chain gave customers a spring flower on 8 March and ran discounts (2021). — [newsru.co.il 2016](https://www.newsru.co.il/rest/7mar2016/kuba.html); [newsru.co.il 2021 (advertorial)](https://www.newsru.co.il/rest/4mar2021/shefa.html)
- Purim 2027: Ta'anit Esther and Erev Purim are Mon 22 Mar, Purim is Tue 23 Mar, and Shushan Purim (Jerusalem) is Wed 24 Mar. — [hebcal 2027 (Israel)](https://www.hebcal.com/holidays/2027?i=on)
- UK Mothering Sunday is Sun 7 Mar 2027 (Western Easter Sun 28 Mar minus 21 days). — computed (dateutil)

### Inferences (recommended actions)
- **UK Mothering Sunday, Sun 7 Mar (EN, UK-targeted only)**
  - Angle: "Mum, then and now": animate her childhood or wedding photo.
  - Timing: ads 21 Feb to 4 Mar. Last order Thu 4 Mar.
  - Do not show this to US audiences, whose Mother's Day is 9 May.
- **International Women's Day, Mon 8 Mar (RU primary, HE secondary)**
  - Angle: "Для мамы и бабушки" (for mum and grandma): an animated portrait of grandmother as a young woman, perhaps with spring-flower motifs (mimosa and tulips are traditional, per post-Soviet custom; not separately sourced).
  - Tone: warm, admiring, celebratory.
  - Hebrew angle: honouring "the women who built our family", less gift-driven.
  - Timing: Russian-language push 22 Feb to 6 Mar.
  - Last order: absolute Sat 6 Mar, but use Fri 5 Mar if the studio is closed on Shabbat. Communicate Thu 4 Mar as "guaranteed".
- **Purim, eve Mon 22 Mar, day Tue 23 Mar (HE)**
  - Purim gifting is mishloach manot (food gifts), so a direct sales fit is weak.
  - Content angle: "תחפושות מפעם" (costumes from back then). Animate childhood Purim-costume photos from the 70s-90s as playful, shareable content or a user-generated contest.
  - Tone: playful and humorous.
  - Timing: 15-22 Mar.
  - Last order: if a product is offered, Sun 21 Mar.
- **Western Easter, Sun 28 Mar**: not worth a campaign.

### Gaps
- No quantitative source on 8 March gift-buying among Russian-speaking Israelis was found. The search returned mostly old advertorials and Russian (not Israeli) gift guides.
- The mimosa and tulip customs come from general cultural knowledge and were not sourced.

---

## 5. April 2027: Passover (Pesach) and the Seder

### Takeaway
The Seder night, Wed 21 Apr 2027, is the year's biggest multi-generational gathering. "והגדת לבנך" ("and you shall tell your child", the core of the Seder) is a natural fit for a product that brings the older generations' faces to the table. Pesach should be the main spring campaign in all three languages, running from right after Purim to a last order date around Sun 18 Apr.

### Cited Findings
- Erev Pesach and Seder night are Wed 21 Apr 2027, and Pesach I is Thu 22 Apr. In Israel the 7th day (end of the holiday) is Wed 28 Apr. In the diaspora Pesach VIII is Thu 29 Apr, and diaspora communities hold a second Seder on Thu 22 Apr evening. — [hebcal 2027](https://www.hebcal.com/holidays/2027?i=on); computed 7th day (pyluach)
- School Pesach break is reportedly about 6-21 Nisan (about Tue 13 to Wed 28 Apr), with school resuming on Thu 29 Apr 2027 (Isru Chag is a school day). — [rng.org.il](https://rng.org.il/uploads/n/1785678884.5499.pdf); [Israel Hayom vacation calendar](https://www.israelhayom.co.il/vacation-calendar) (secondary; the Mako guide's dates were inconsistent)

### Inferences (recommended actions)
- **Why it fits**: the whole extended family is at one table, and the Haggadah's theme is passing the story to the next generation. A 30-60 second "our family's journey" video (great-grandparents, aliyah photos, past Seders) shown on a TV or phone at the Seder, or sent to the family group, is a strong emotional gift. It also works as a host gift instead of wine or flowers.
- **Angles**:
  - HE: "ליל הסדר: כשכל הדורות סביב השולחן" (Seder night: all the generations around the table), and "המקום הפנוי ליד השולחן" (the empty seat at the table, for a grandparent who has passed; handle gently).
  - RU: "Песах всей семьёй" (Pesach with the whole family). Also aliyah stories: photos from the 1990s arrival next to Soviet-era photos.
  - EN diaspora: "Bring Bubbe and Zaide to this year's Seder", plus distant family who cannot travel.
- **Tone**: warm, festive, family. Include remembrance gently, since many families feel the absence of the departed at the Seder (inference).
- **Timing**:
  - Start Thu 25 Mar (after Shushan Purim), about 4 weeks out.
  - Main push 4-18 Apr. Israeli households are busy cleaning and shopping in the last week, so make "order early" the message from about 11 Apr.
- **Last order**: to receive it before the Seder on Wed 21 Apr, absolute last order Mon 19 Apr (morning), safe Sun 18 Apr. Expect heavy volume and consider capping orders. For the diaspora second Seder (Thu 22 Apr evening), Tue 20 Apr.
- **During the holiday**:
  - Production and delivery stop on Yom Tov (Thu 22 Apr and Wed 28 Apr in Israel) if the studio observes it.
  - Chol HaMoed (Fri 23 to Tue 27 Apr) is family-trip time. Promote "make a memory video from this Pesach's photos" for Isru Chag and afterwards.
- **Mimouna (night of Wed 28 Apr)**: an optional Hebrew content touch for Moroccan-heritage families, for example animated old family photos from Morocco. Low priority.
- **Sensitivity**: low to moderate. Yom HaShoah starts 5 days after Pesach ends (Mon 3 May evening), so the post-Pesach campaign must wind down by 2 May.

### Gaps
- No Israeli source was found on lead times or gift-buying behaviour for Pesach (for example when Israelis buy host gifts). The timing is inferred.
- The official Ministry of Education Pesach break dates were not fetched.

---

## 6. May 2027: Yom HaShoah, Victory Day, Mother's Day, Yom HaZikaron, Yom HaAtzmaut, Lag BaOmer (and Shavuot)

### Takeaway
3-12 May is a mix of national mourning, commemoration and celebration. For a brand whose product is literally "bringing the dead back to life on screen", the safe rule is:
- Full commercial silence (no paid ads, no offers, no CTAs) from Mon 3 May evening to Tue 4 May nightfall (Yom HaShoah), and from Mon 10 May afternoon to Tue 11 May nightfall (Yom HaZikaron).
- At most one non-commercial commemorative post, with no product shown, on each day.
- Victory Day (Sun 9 May) is commemorative but proud for Russian speakers. Veterans' portraits are highly relevant, but they must be offered as a tribute, not a sale.
- US Mother's Day (also 9 May) runs only in English to diaspora targets, ending before 10 May.
- Lag BaOmer (Tue 25 May) opens the wedding season.

### Cited Findings
- Yom HaShoah is Tue 4 May 2027, from sundown Mon 3 May. Yom HaZikaron is 4 Iyar (Tue 11 May) and Yom HaAtzmaut is 5 Iyar (Wed 12 May). — [hebcal 2027](https://www.hebcal.com/holidays/2027?i=on); [USC calendar](https://orsl.usc.edu/life/jewish-holy-days-calendar/); [hebcal Yom HaZikaron 2027](https://www.hebcal.com/holidays/yom-hazikaron-2027); [Shalhevet](https://www.shalhevet.org/apps/events/44701310/)
- Second Authority (Israeli commercial broadcast regulator) rules bar promotional content inside programmes on special days, naming Memorial Day, Holocaust Day, Tisha B'Av and national mourning days. A separate Second Authority guideline holds that advertisements may not be broadcast during reporting on terror attacks. — [ice.co.il](https://www.ice.co.il/media/news/article/1132778); [ice.co.il](https://www.ice.co.il/tv/news/article/845415) (these cover broadcast and embedded content, not social media; whether standalone TV spots are banned on these days was not confirmed)
- Brand posts on Holocaust Remembrance Day have drawn public criticism as commercialisation; Time Out Israel's piece is titled "אל תשכחו להוסיף לוגו: יום השואה של הקפיטליזם המאוחר" ("don't forget to add the logo: late capitalism's Holocaust Day"). Influencer stories for Yom HaZikaron that turned out to be paid ("בשיתוף", "in collaboration with") caused a storm. A TikTok Holocaust trend drew anger and its hashtag was removed. Commentators warn that the main danger is trivialisation of the Holocaust as "content in the feed". — [Time Out Israel](https://timeout.co.il/%D7%94%D7%A9%D7%95%D7%90%D7%94-%D7%A7%D7%A4%D7%99%D7%98%D7%9C%D7%99%D7%96%D7%9D/); [ice.co.il on paid Memorial Day influencer stories](https://www.ice.co.il/social/news/article/960358); [IDI](https://www.idi.org.il/articles/63931); [Maariv](https://www.maariv.co.il/news/israel/article-1277700)
- Victory Day:
  - Israel marks 9 May as Victory Day over Nazi Germany under the "Victory Day over Nazi Germany Law, 5777-2017" (passed July 2017).
  - Earlier, the 2000 WWII Veterans Status Law set 9 May by an indirect amendment to the Yad Vashem law. That amendment lets the government move the date when it falls on a holiday, Shabbat, memorial day or state observance, or on the day before one.
  - Israel follows the Soviet 9 May date (Moscow time) instead of the Western 8 May.
  - Sources: [Wikipedia: Victory in Europe Day (Israel)](https://en.wikipedia.org/wiki/Victory_in_Europe_Day_(Israel)); [HaMichlol](https://www.hamichlol.org.il/%D7%99%D7%95%D7%9D_%D7%94%D7%A0%D7%99%D7%A6%D7%97%D7%95%D7%9F_%D7%91%D7%97%D7%91%D7%A8_%D7%94%D7%9E%D7%93%D7%99%D7%A0%D7%95%D7%AA); [Knesset law text (2000)](https://fs.knesset.gov.il/15/law/15_lsr_300209.pdf); [Al-Monitor 2017](https://al-monitor.com/originals/2017/08/israel-russia-victory-day-national-holiday-relations.html)
- US, Canada and Australia Mother's Day is Sun 9 May 2027. Lag BaOmer is Tue 25 May 2027 (eve Mon 24 May). Shavuot is Fri 11 Jun 2027 (eve Thu 10 Jun), outside the period. — computed (dateutil / pyluach)
- Lag BaOmer is seen as the opening of the wedding season. The Chief Rabbinate adopted the Omer mourning customs and does not hold weddings during the Omer, although some communities' rabbis allow weddings from Lag BaOmer to Shavuot. Peak wedding season is summer, when weddings cost about 20% more than in winter. — [Israel Hayom](https://www.israelhayom.co.il/lifestyle/relationship/article/17956658); [Kipa](https://www.kipa.co.il/יחסים/חתונה/1157114-0); [Walla](https://news.walla.co.il/item/2632020); [Israel Hayom summer weddings](https://www.israelhayom.co.il/article/85633)

### Inferences (recommended actions, in date order)
- **Thu 29 Apr to Sun 2 May: post-Pesach**
  - Launch the US Mother's Day campaign in English, geo-targeted to the US, Canada and Australia.
  - Start the Victory Day "tribute" offer in Russian (see 9 May).
  - Orthodox Easter (2 May): no action.
- **Yom HaShoah, Mon 3 May (about 16:00) to Tue 4 May (nightfall): FULL PAUSE**
  - Pause all paid campaigns in all languages. Diaspora Jewish communities also mark Yom HaShoah, and 27 January is the international day.
  - No scheduled sales posts, no "last chance" messages, no WhatsApp broadcast offers. Pause automated retargeting.
  - Optional: one post (candle, "זוכרים", "we remember") with no logo-led product, no CTA and no link. Silence is also acceptable and arguably safer for a commercial memory brand.
  - Never use real Holocaust victims' or survivors' photos, animated or not, in marketing. Do not run "animate your survivor grandparent" offers. Animating victims' faces risks the trivialisation criticism cited above (inference).
  - Individual customer requests for survivor photos: handle privately, with extra care and consent. Consider a non-commercial collaboration with a testimony or commemoration organisation only after expert consultation (inference).
- **Tue 4 May evening to Sat 8 May**: resume gently. Mother's Day (EN) and Victory Day (RU) last-call messages.
- **Victory Day, Sun 9 May (RU primary)**
  - Why it fits: WWII veterans' portraits (grandfathers and great-grandfathers in uniform, with medals) are cherished family photos among Israeli Russian speakers. Animating a veteran's portrait for 9 May is probably the single most emotionally relevant use case in the RU segment (inference).
  - Angle: "Помним. Гордимся." ("We remember. We are proud.", a common 9 May phrase) and "Оживите фото героя семьи" (bring the photo of the family's hero to life).
  - Tone: dignified, proud, respectful. Not jokey. No discounts language like "sale" or "-30%". Frame it as a "tribute" with a fixed price.
  - Political sensitivity: since 2022 many Israeli Russian speakers come from Ukraine and other non-Russian countries, so do not use Russian-state symbols (for example the St. George ribbon) or "Russian" framing. Use Israel's own framing, "Victory over Nazi Germany" / "День Победы над нацистской Германией", and the Jewish soldiers' heritage (inference).
  - Last order: absolute Fri 7 May, safe Thu 6 May.
- **US/Canada/Australia Mother's Day, Sun 9 May (EN)**
  - Angle: "Mom, then and now"; "Grandma's wedding photo, alive again".
  - Timing: run 25 Apr to 7 May, with no Israel geo-targeting on 3-4 May.
  - Last order: Fri 7 May Israel time (safe Thu 6 May). WhatsApp delivery Saturday night or Sunday morning lands before Mother's Day in US time zones (7-10 hours behind Israel).
- **Yom HaZikaron, Mon 10 May (from about 16:00; siren at 20:00) to Tue 11 May evening: FULL PAUSE**
  - Same rules as Yom HaShoah. Bereaved families are part of every audience. A brand that animates photos of the dead must not appear to profit from the fallen.
  - Optional: a single "יהי זכרם ברוך" ("may their memory be a blessing") post with no product.
  - Requests to animate fallen soldiers' photos: handle privately and with great care, and possibly pro bono (inference). Never use them in marketing without explicit family consent, and preferably not at all.
  - Also prepare an ad-hoc pause protocol for terror attacks or declared national mourning days, in line with the Second Authority's broadcast practice cited above.
  - Siren times (20:00 eve, 11:00 day) are standard practice and were not separately sourced in this session.
- **Yom HaAtzmaut, from Tue 11 May evening, Wed 12 May (HE, RU, EN)**
  - Start posting only after the transition ceremony on Tue evening.
  - Angle: "משפחות שבנו את המדינה" (families that built the country): aliyah photos, grandparents in early-state photos, animated. Celebratory, proud.
  - A light holiday offer on Wed 12 May is acceptable (inference: Independence Day is festive). Avoid a hard sell in the hours straight after Memorial Day.
- **Lag BaOmer, eve Mon 24 May, Tue 25 May (HE)**
  - The opening of the wedding season (see section 7).
  - Angle: launch a "חתונה" (wedding) line, for example animated grandparents' and parents' wedding photos for the wedding screen or the "under the chuppah" tribute.
  - Tone: festive.
  - Also bonfire nostalgia content.
- **Late May (Shavuot, Fri 11 Jun; Yom Yerushalayim, Fri 4 Jun)**: just outside the range. Shavuot (Book of Ruth, harvest, kindergarten "bikkurim" first-fruits ceremonies) is weak for this product. End of the school year and graduation season (June) is a stronger next hook, with "class of" memories and teacher gifts (inference).

### Gaps
- No Israeli regulator or industry guidance for social-media brand conduct on Yom HaShoah or Yom HaZikaron was found. The cited material covers broadcast rules and public criticism, so the "full pause" recommendation is a best-practice inference.
- The Law on Holocaust Remembrance Day's rules on closing entertainment venues were not fetched in this session.
- The Immortal Regiment (Бессмертный полк) marches with veterans' portraits in Israeli cities, and Victory Day parades of veterans in Israel, are known from general knowledge but were not sourced this session.
- The government decision confirming the 2027 Victory Day date was not found. 9 May is assumed.
- No source measured how Israeli Russian speakers react to commercial Victory Day content.

---

## 7. Year-round occasions: bar/bat mitzvah, weddings, and the 7th-grade roots project (עבודת שורשים)

### Takeaway
The roots project sits in the 7th-grade (כיתה ז') curriculum, which is also the bar/bat mitzvah year. The deadline is set by each school, not nationally. The family-research phase and the "ערב שורשים" (roots evening, a family presentation night) usually fall in the second half of the school year: one school calendar shows a roots workshop in February and a roots evening in March. That makes January to May a strong window for targeting parents of 12-13-year-olds. Weddings are blocked for observant couples during the Omer (Pesach to Lag BaOmer) and peak in summer.

### Cited Findings
- The Ministry of Education 7th-grade curriculum (Israeli-Jewish Culture / "Heritage Paths", שבילי מורשת) treats this year as suited to a significant roots-research project ("עבודת חקר-שורשים"), including family and community interviews. — [MoE grade 7 curriculum](https://pop.education.gov.il/tchumey_daat/israeli-jewish-culture/junior-high/curriculum/grade7/); [MoE Heritage Paths grade 7](https://pop.education.gov.il/tchumey_daat/heritage-paths/junior-high/curriculum/7th-grade/); [MoE teacher roots guide (Rama)](https://meyda.education.gov.il/files/Rama/teacher_shorashim_guide.pdf)
- Deadlines are set per school. A school guidebook (Makif Heh, Ashdod) has its own timeline section, and one 7th-grade events calendar (March 2025) lists a roots workshop in February and a "ערב שורשים" in its school events. No national deadline was found. — [Makif Heh roots guide](https://makifh.schooly.co.il/wp-content/uploads/2018/10/חוברת-הנחיות-לכתיבת-עבודת-שורשים.pdf); [school events schedule (Google Doc)](https://docs.google.com/document/d/1-CMTMYVy6C-_gtvnzcin8mY78DQK6gA5/export?format=pdf)
- Weddings:
  - Omer mourning customs prohibit weddings. The Chief Rabbinate adopted these customs, and weddings usually resume from Lag BaOmer, with differing community customs (some allow Lag BaOmer to Shavuot).
  - There are about ten different customs about which days weddings are avoided.
  - Summer is peak season.
  - Sources: [Kipa](https://www.kipa.co.il/יחסים/חתונה/1157114-0); [Israel Hayom](https://www.israelhayom.co.il/lifestyle/relationship/article/17956658); [Walla](https://news.walla.co.il/item/2632020)

### Inferences (recommended actions)
- **Roots project (HE primary; RU families too)**
  - Target parents of 7th graders, and of 6th graders in schools that start earlier. Run January to May, with a content peak around Tu BiShvat (Sat 23 Jan) and a sales push February to April (before roots evenings).
  - Product idea: a "חבילת עבודת שורשים" (roots project package). Restore and animate 3-5 great-grandparent photos, delivered as video files the child can embed in the presentation and show at the roots evening.
  - Tone: educational and proud, aimed at the child and the parent.
  - Lead time: about a week before the school deadline, to allow photo collection from relatives. Production itself is 48h.
  - Channels: parent WhatsApp groups and school parent committees (inference).
  - Because deadlines vary by school, use rolling "בעוד שבוע הגשה?" ("deadline next week?") messaging, not one fixed date.
- **Bar/bat mitzvah (year-round; ages 12 for girls and 13 for boys, most in the 7th-grade year)**
  - Position as a segment for the event slideshow or video ("from generation to generation": great-grandparents to the bar/bat mitzvah child), or as a grandparents' gift.
  - Lead time: event producers usually need the material 1-2 weeks before the event (inference, not sourced). Partner B2B with event photographers, DJs and slideshow editors.
  - For observant families, no events during the Omer is a wedding custom; bar mitzvah ceremonies themselves continue (inference).
- **Weddings**
  - Peak demand starts after Lag BaOmer (from Tue 25 May 2027) and runs through summer, with a pause during the "Three Weeks" in July (outside the period; inference from general custom).
  - Angle: animate the couple's grandparents' wedding photos for the wedding screen. A tender memorial insert for a grandparent who passed away (handle with permission and gentleness). Parents-of-the-couple gift.
  - Timing: start the wedding-line promotion around 1-15 May (after Yom HaAtzmaut) so couples marrying in June can order. Last order about 1 week before the wedding, to allow for screen testing.
- **Other year-round occasions (not dated)**: birthdays (especially 70th, 80th and 90th of grandparents), anniversaries, shiva and memorial (azkara) gatherings, and aliyah anniversaries. Memorial uses need a gentle, opt-in sales approach (inference).

### Gaps
- No national Ministry of Education rule fixes when the roots project is assigned or presented, and no survey of typical submission months was found. The February/March example is a single school's calendar.
- No source on the seasonality of bar/bat mitzvah events in Israel was found.
- No source was found for the "Three Weeks" wedding pause or the lead times of event producers; these come from general knowledge.

---

## 8. Cross-cutting operational rules: lead times, last order dates, Shabbat, languages

### Takeaway
Digital delivery in 24-48h makes Zikaron Chai a natural "last-minute" gift, which is a real edge against physical gifts that need shipping. But peak volume, Shabbat and Yom Tov closures, and the need to collect photos from relatives mean the customer-facing "guaranteed by" date should be 3 days before the event, with an "express" fallback at 48h.

### Cited Findings
- Hanukkah's first and eighth candles fall on Fridays and are lit before Shabbat. — [Chabad](https://www.chabad.org/holidays/chanukah/)
- Pesach Yom Tov days in Israel are Thu 22 Apr and Wed 28 Apr 2027; Yom HaShoah starts Mon 3 May evening; Yom HaZikaron Tue 11 May (eve Mon 10 May). — [hebcal 2027](https://www.hebcal.com/holidays/2027?i=on); computed (pyluach)

### Inferences: master "promote / last order / pause" schedule

| Occasion | Language focus | Start promoting | Peak | Safe last order (communicate) | Absolute last order (48h) | Pause / quiet |
|---|---|---|---|---|---|---|
| Hanukkah (1st candle Fri 4 Dec) | HE, RU, EN | Now (23 Nov) | 29 Nov - 9 Dec | Tue 1 Dec (1st night); Tue 8 Dec (8th night) | Wed 2 Dec; Wed 9 Dec | Shabbat 4-5, 11-12 Dec for religious targeting |
| 10 Tevet (Sun 20 Dec) | - | - | - | - | - | low-key day |
| Christmas (Fri 25 Dec) | EN | 1 Dec | 14-22 Dec | Tue 22 Dec | Wed 23 Dec | - |
| Novy God (Thu 31 Dec night) | RU | 1 Dec (soft), 13 Dec (main) | 20-29 Dec | Mon 28 Dec | Tue 29 Dec | - |
| Old New Year (night 13 Jan) | RU | 4 Jan | 8-11 Jan | Sun 10 Jan | Mon 11 Jan | - |
| Tu BiShvat (Sat 23 Jan) | HE | 17 Jan | content only | - | - | Shabbat |
| Int'l Holocaust Remembrance Day (Wed 27 Jan) | EN | - | - | - | - | pause EN promos |
| Family Day (Sun 7 Feb) | HE, RU | Sun 24 Jan | 31 Jan - 5 Feb | Thu 4 Feb | Fri 5 Feb | - |
| Valentine's Day (Sun 14 Feb) | HE, RU, EN | Mon 8 Feb | 8-12 Feb | Thu 11 Feb | Fri 12 Feb | - |
| UK Mothering Sunday (Sun 7 Mar) | EN-UK | 21 Feb | 28 Feb - 4 Mar | Wed 3 Mar | Thu 4 Mar | - |
| Women's Day (Mon 8 Mar) | RU, HE | 22 Feb | 1-5 Mar | Thu 4 Mar | Fri 5 Mar (Sat 6 if open on Shabbat) | - |
| Purim (Tue 23 Mar) | HE | 15 Mar | content | Fri 19 Mar | Sun 21 Mar | - |
| Pesach Seder (Wed 21 Apr) | HE, RU, EN | Thu 25 Mar | 4-18 Apr | Sun 18 Apr | Mon 19 Apr | Yom Tov 22 & 28 Apr |
| US Mother's Day (Sun 9 May) | EN | 25 Apr | 29 Apr - 7 May (not 3-4 May) | Thu 6 May | Fri 7 May | 3 May eve - 4 May |
| Yom HaShoah (Mon 3 May eve - Tue 4 May) | all | - | - | - | - | FULL PAUSE |
| Victory Day (Sun 9 May) | RU | 29 Apr | 5-7 May | Thu 6 May | Fri 7 May | tone: tribute, no "sale" |
| Yom HaZikaron (Mon 10 May eve - Tue 11 May) | all | - | - | - | - | FULL PAUSE (from Mon 10 May afternoon) |
| Yom HaAtzmaut (Tue 11 May eve - Wed 12 May) | HE, RU, EN | after Tue evening ceremony | 12 May | - | - | soft celebratory |
| Lag BaOmer / wedding season (Tue 25 May) | HE | 13 May | 20-31 May | ~1 week before each wedding | - | - |
| Roots project / bar-bat mitzvah | HE, RU | Jan (rolling) | Feb - Apr | ~1 week before school deadline or event | 48h | - |

- Additional operating rules (inference):
  - Pause automated retargeting and WhatsApp broadcasts on both memorial days. Turning off manual posts is not enough.
  - Keep a pre-written "national mourning / security event" pause protocol ready.
  - Show "guaranteed by" dates in each language on the landing page.
  - Do not deliver on Shabbat or Yom Tov to customers who indicate they are observant.
  - For the diaspora, express last order dates in the customer's own time zone.

### Gaps
- Whether the business works on Shabbat and holidays is unknown, and it changes the last order dates. Both variants are given where relevant.
- No Israeli retail source on typical gift lead times for digital products was found.
