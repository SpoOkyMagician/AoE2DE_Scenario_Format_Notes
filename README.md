# AoE2DE_Scenario_Format_Notes
This is my notes on the scenario format of 1.51... I am really getting frustrated working on this so, I am going to upload my current notes. I dunno if I will finish these but, this will hopefully explain it a bit more to you.

Note: Most of my information comes from the scenario parser of course. (Thanks a lot KSneijders.)

https://github.com/KSneijders/AoE2ScenarioParser/blob/542f07414551eb2c15c7a8cbb7f7618b2ca4cab5/AoE2ScenarioParser/versions/DE/v1.51/structure.json

Note: I was comparing a scenario I made in game ("_ALL_SCENARIO_STUFF_OBJECTS") to the actual results. (I wanted to be sure exactly what was happening to the file/bytes directly.)

Progress: I am currently at disabled techs and I am considering giving up at this point. There is WAY TOO MUCH DATA to handle here... (I am sure I could finish it eventually but, ugh...) Note: I left off at: 0000AC80 on "53 00 00 00".

Personal Note: Honestly, there is way too much redundant/useless data in this file... (They really need to re-format this damn thing...)

Personal Scenario Format Note: I made a file in xml/json of what it honestly should look like... (generally speaking. not fully.)

update: Added the scenario header and decompressed file.

update: Added program.vb to decompress/compress scenarios. (Visual Basic) Pretty much all the credit goes to the site's owner/creator/host. Thanks!

Header Note: If you are wondering, the compression starts 4 characters after the "creator name". It usually starts with a [] looking character. (It's a byte.) You can remove all the stuff before that and you can decompress the remaining data. Just remember, once you are done editing the decompressed data, compress it, and re add all the previous data (header) to the file and it should load just fine in game. (assuming nothing goes wrong with the decompressed data...)
