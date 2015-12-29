﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace BlacksmithPress.CodeMash.Schedule.Controllers
{
    [Route("api/[controller]")]
    public class CalendarController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return
@"BEGIN:VCALENDAR
PRODID:-//Google Inc//Google Calendar 70.9054//EN
VERSION:2.0
CALSCALE:GREGORIAN
METHOD:PUBLISH
X-WR-TIMEZONE:America/New_York
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161010
DTEND;VALUE=DATE:20161011
DTSTAMP:20151228T214847Z
UID:20161010_60o30dr5c8o38e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20151201T002258Z
DESCRIPTION:Public holiday in: Alabama\, American Samoa\, Arizona\, Colorad
 o\, Connecticut\, District of Columbia\, Georgia\, Idaho\, Illinois\, India
 na\, Iowa\, Kansas\, Kentucky\, Louisiana\, Maine\, Maryland\, Massachusett
 s\, Mississippi\, Missouri\, Montana\, Nebraska\, New Hampshire\, New Jerse
 y\, New Mexico\, New York\, North Carolina\, Northern Mariana Islands\, Ohi
 o\, Oklahoma\, Pennsylvania\, Rhode Island\, South Carolina\, Tennessee\, U
 tah\, Virgin Islands\, Virginia\, West Virginia
LAST-MODIFIED:20151201T002258Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Columbus Day (regional holiday)
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151012
DTEND;VALUE=DATE:20151013
DTSTAMP:20151228T214847Z
UID:20151012_60o30dr5c8o38e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20151201T002258Z
DESCRIPTION:Public holiday in: Alabama\, American Samoa\, Arizona\, Colorad
 o\, Connecticut\, District of Columbia\, Georgia\, Idaho\, Illinois\, India
 na\, Iowa\, Kansas\, Kentucky\, Louisiana\, Maine\, Maryland\, Massachusett
 s\, Mississippi\, Missouri\, Montana\, Nebraska\, New Hampshire\, New Jerse
 y\, New Mexico\, New York\, North Carolina\, Northern Mariana Islands\, Ohi
 o\, Oklahoma\, Pennsylvania\, Rhode Island\, South Carolina\, Tennessee\, U
 tah\, Virgin Islands\, Virginia\, West Virginia
LAST-MODIFIED:20151201T002258Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Columbus Day (regional holiday)
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141013
DTEND;VALUE=DATE:20141014
DTSTAMP:20151228T214847Z
UID:20141013_60o30dr5c8o38e1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20151201T002258Z
DESCRIPTION:Public holiday in: Alabama\, American Samoa\, Arizona\, Colorad
 o\, Connecticut\, District of Columbia\, Georgia\, Idaho\, Illinois\, India
 na\, Iowa\, Kansas\, Kentucky\, Louisiana\, Maine\, Maryland\, Massachusett
 s\, Mississippi\, Missouri\, Montana\, Nebraska\, New Hampshire\, New Jerse
 y\, New Mexico\, New York\, North Carolina\, Northern Mariana Islands\, Ohi
 o\, Oklahoma\, Pennsylvania\, Rhode Island\, South Carolina\, Tennessee\, U
 tah\, Virgin Islands\, Virginia\, West Virginia
LAST-MODIFIED:20151201T002258Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Columbus Day (regional holiday)
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160215
DTEND;VALUE=DATE:20160216
DTSTAMP:20151228T214847Z
UID:20160215_60o30dr570o30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20150929T224705Z
DESCRIPTION:
LAST-MODIFIED:20150929T224705Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Presidents' Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150216
DTEND;VALUE=DATE:20150217
DTSTAMP:20151228T214847Z
UID:20150216_60o30dr570o30e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20150929T224705Z
DESCRIPTION:
LAST-MODIFIED:20150929T224705Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Presidents' Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140217
DTEND;VALUE=DATE:20140218
DTSTAMP:20151228T214847Z
UID:20140217_60o30dr570o30e1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20150929T224705Z
DESCRIPTION:
LAST-MODIFIED:20150929T224705Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Presidents' Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160508
DTEND;VALUE=DATE:20160509
DTSTAMP:20151228T214847Z
UID:20160508_60o30dr560o30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20150624T224854Z
DESCRIPTION:
LAST-MODIFIED:20150624T224854Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Mother's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150510
DTEND;VALUE=DATE:20150511
DTSTAMP:20151228T214847Z
UID:20150510_60o30dr560o30e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20150624T224854Z
DESCRIPTION:
LAST-MODIFIED:20150624T224854Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Mother's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140511
DTEND;VALUE=DATE:20140512
DTSTAMP:20151228T214847Z
UID:20140511_60o30dr560o30e1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20150624T224854Z
DESCRIPTION:
LAST-MODIFIED:20150624T224854Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Mother's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160619
DTEND;VALUE=DATE:20160620
DTSTAMP:20151228T214847Z
UID:20160619_60o30dr564o30e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20150624T224854Z
DESCRIPTION:
LAST-MODIFIED:20150624T224854Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Father's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150621
DTEND;VALUE=DATE:20150622
DTSTAMP:20151228T214847Z
UID:20150621_60o30dr564o30e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20150624T224854Z
DESCRIPTION:
LAST-MODIFIED:20150624T224854Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Father's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140615
DTEND;VALUE=DATE:20140616
DTSTAMP:20151228T214847Z
UID:20140615_60o30dr564o30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20150624T224854Z
DESCRIPTION:
LAST-MODIFIED:20150624T224854Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Father's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160313
DTEND;VALUE=DATE:20160314
DTSTAMP:20151228T214847Z
UID:20160313_60o30c9o60o30dpj6sqj0dr560@google.com
CLASS:PUBLIC
CREATED:20150421T230710Z
DESCRIPTION:
LAST-MODIFIED:20150421T230710Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Daylight Saving Time starts
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161106
DTEND;VALUE=DATE:20161107
DTSTAMP:20151228T214847Z
UID:20161106_60o30c9o64o30dpj6sqj0dr560@google.com
CLASS:PUBLIC
CREATED:20150421T230710Z
DESCRIPTION:
LAST-MODIFIED:20150421T230710Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Daylight Saving Time ends
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151226
DTEND;VALUE=DATE:20151227
DTSTAMP:20151228T214847Z
UID:20151226_60o30o9l74o3ac1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20141208T234453Z
DESCRIPTION:
LAST-MODIFIED:20141208T234453Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Day After Christmas Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160905
DTEND;VALUE=DATE:20160906
DTSTAMP:20151228T214847Z
UID:20160905_60o30dr5c4o30e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033302Z
DESCRIPTION:
LAST-MODIFIED:20140109T033302Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Labor Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150703
DTEND;VALUE=DATE:20150704
DTSTAMP:20151228T214847Z
UID:20150703_60o30dr470o30e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033302Z
DESCRIPTION:
LAST-MODIFIED:20140109T033302Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Independence Day observed
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140420
DTEND;VALUE=DATE:20140421
DTSTAMP:20151228T214847Z
UID:20140420_60o30dr660o30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033302Z
DESCRIPTION:
LAST-MODIFIED:20140109T033302Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Easter Sunday
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161111
DTEND;VALUE=DATE:20161112
DTSTAMP:20151228T214847Z
UID:20161111_60o30dr568o30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Veterans Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141111
DTEND;VALUE=DATE:20141112
DTSTAMP:20151228T214847Z
UID:20141111_60o30dr568o30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Veterans Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161124
DTEND;VALUE=DATE:20161125
DTSTAMP:20151228T214847Z
UID:20161124_60o30dr5cco30e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Thanksgiving Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141127
DTEND;VALUE=DATE:20141128
DTSTAMP:20151228T214847Z
UID:20141127_60o30dr5cco30e1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Thanksgiving Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160118
DTEND;VALUE=DATE:20160119
DTSTAMP:20151228T214847Z
UID:20160118_60o30dr56oo30e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Martin Luther King Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140120
DTEND;VALUE=DATE:20140121
DTSTAMP:20151228T214847Z
UID:20140120_60o30dr56oo30e1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Martin Luther King Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150907
DTEND;VALUE=DATE:20150908
DTSTAMP:20151228T214847Z
UID:20150907_60o30dr5c4o30e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Labor Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160704
DTEND;VALUE=DATE:20160705
DTSTAMP:20151228T214847Z
UID:20160704_60o30dr470o30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Independence Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161108
DTEND;VALUE=DATE:20161109
DTSTAMP:20151228T214847Z
UID:20161108_60o30dr66go30e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Election Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150405
DTEND;VALUE=DATE:20150406
DTSTAMP:20151228T214847Z
UID:20150405_60o30dr660o30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Easter Sunday
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151225
DTEND;VALUE=DATE:20151226
DTSTAMP:20151228T214847Z
UID:20151225_60o30dr56go30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033301Z
DESCRIPTION:
LAST-MODIFIED:20140109T033301Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Christmas Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151111
DTEND;VALUE=DATE:20151112
DTSTAMP:20151228T214847Z
UID:20151111_60o30dr568o30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Veterans Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160214
DTEND;VALUE=DATE:20160215
DTSTAMP:20151228T214847Z
UID:20160214_60o30dr46so30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Valentine's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160413
DTEND;VALUE=DATE:20160414
DTSTAMP:20151228T214847Z
UID:20160413_60o30o9lc8o30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Thomas Jefferson's Birthday
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150413
DTEND;VALUE=DATE:20150414
DTSTAMP:20151228T214847Z
UID:20150413_60o30o9lc8o30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Thomas Jefferson's Birthday
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140413
DTEND;VALUE=DATE:20140414
DTSTAMP:20151228T214847Z
UID:20140413_60o30o9lc8o30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Thomas Jefferson's Birthday
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151126
DTEND;VALUE=DATE:20151127
DTSTAMP:20151228T214847Z
UID:20151126_60o30dr5cco30e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Thanksgiving Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161231
DTEND;VALUE=DATE:20170101
DTSTAMP:20151228T214847Z
UID:20161231_60o30dr4coo30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:New Year's Eve
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151231
DTEND;VALUE=DATE:20160101
DTSTAMP:20151228T214847Z
UID:20151231_60o30dr4coo30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:New Year's Eve
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160101
DTEND;VALUE=DATE:20160102
DTSTAMP:20151228T214847Z
UID:20160101_60o30dr46oo30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:New Year's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150525
DTEND;VALUE=DATE:20150526
DTSTAMP:20151228T214847Z
UID:20150525_60o30dr56co30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Memorial Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140526
DTEND;VALUE=DATE:20140527
DTSTAMP:20151228T214847Z
UID:20140526_60o30dr56co30e1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Memorial Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150119
DTEND;VALUE=DATE:20150120
DTSTAMP:20151228T214847Z
UID:20150119_60o30dr56oo30e1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Martin Luther King Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150704
DTEND;VALUE=DATE:20150705
DTSTAMP:20151228T214847Z
UID:20150704_60o30dr470o30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Independence Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161031
DTEND;VALUE=DATE:20161101
DTSTAMP:20151228T214847Z
UID:20161031_60o30dr4cko30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Halloween
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160327
DTEND;VALUE=DATE:20160328
DTSTAMP:20151228T214847Z
UID:20160327_60o30dr660o30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Easter Sunday
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151101
DTEND;VALUE=DATE:20151102
DTSTAMP:20151228T214847Z
UID:20151101_60o30c9o64o30dpj6sqj0dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Daylight Saving Time ends
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141102
DTEND;VALUE=DATE:20141103
DTSTAMP:20151228T214847Z
UID:20141102_60o30c9o64o30dpj6sqj0dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Daylight Saving Time ends
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161224
DTEND;VALUE=DATE:20161225
DTSTAMP:20151228T214847Z
UID:20161224_60o30dr56ko30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Christmas Eve
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151224
DTEND;VALUE=DATE:20151225
DTSTAMP:20151228T214847Z
UID:20151224_60o30dr56ko30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Christmas Eve
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161226
DTEND;VALUE=DATE:20161227
DTSTAMP:20151228T214847Z
UID:20161226_60o30dr56go30e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033300Z
DESCRIPTION:
LAST-MODIFIED:20140109T033300Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Christmas Day observed
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150214
DTEND;VALUE=DATE:20150215
DTSTAMP:20151228T214847Z
UID:20150214_60o30dr46so30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Valentine's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140214
DTEND;VALUE=DATE:20140215
DTSTAMP:20151228T214847Z
UID:20140214_60o30dr46so30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Valentine's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141231
DTEND;VALUE=DATE:20150101
DTSTAMP:20151228T214847Z
UID:20141231_60o30dr4coo30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:New Year's Eve
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150101
DTEND;VALUE=DATE:20150102
DTSTAMP:20151228T214847Z
UID:20150101_60o30dr46oo30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:New Year's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140101
DTEND;VALUE=DATE:20140102
DTSTAMP:20151228T214847Z
UID:20140101_60o30dr46oo30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:New Year's Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20160530
DTEND;VALUE=DATE:20160531
DTSTAMP:20151228T214847Z
UID:20160530_60o30dr56co30e1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Memorial Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140901
DTEND;VALUE=DATE:20140902
DTSTAMP:20151228T214847Z
UID:20140901_60o30dr5c4o30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Labor Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140704
DTEND;VALUE=DATE:20140705
DTSTAMP:20151228T214847Z
UID:20140704_60o30dr470o30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Independence Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20151031
DTEND;VALUE=DATE:20151101
DTSTAMP:20151228T214847Z
UID:20151031_60o30dr4cko30c1g60o30dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Halloween
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141031
DTEND;VALUE=DATE:20141101
DTSTAMP:20151228T214847Z
UID:20141031_60o30dr4cko30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Halloween
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20150308
DTEND;VALUE=DATE:20150309
DTSTAMP:20151228T214847Z
UID:20150308_60o30c9o60o30dpj6sqj0dr4co@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Daylight Saving Time starts
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20140309
DTEND;VALUE=DATE:20140310
DTSTAMP:20151228T214847Z
UID:20140309_60o30c9o60o30dpj6sqj0dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Daylight Saving Time starts
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141224
DTEND;VALUE=DATE:20141225
DTSTAMP:20151228T214847Z
UID:20141224_60o30dr56ko30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Christmas Eve
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20161225
DTEND;VALUE=DATE:20161226
DTSTAMP:20151228T214847Z
UID:20161225_60o30dr56go30c1g60o30dr560@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Christmas Day
TRANSP:TRANSPARENT
END:VEVENT
BEGIN:VEVENT
DTSTART;VALUE=DATE:20141225
DTEND;VALUE=DATE:20141226
DTSTAMP:20151228T214847Z
UID:20141225_60o30dr56go30c1g60o30dr4ck@google.com
CLASS:PUBLIC
CREATED:20140109T033259Z
DESCRIPTION:
LAST-MODIFIED:20140109T033259Z
SEQUENCE:0
STATUS:CONFIRMED
SUMMARY:Christmas Day
TRANSP:TRANSPARENT
END:VEVENT
END:VCALENDAR
";
        }

    }
}
