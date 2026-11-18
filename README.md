# RandomMapGenerator_RA2 #
How to use
-------
- download release or clone & build
- change game folder in settings.ini
- click run.bat to create random map
- click help.bat to see additional command lines
- examples of map units can be seen in /MapUnits

VERA20K extended maps
-------
VERA20K supports maps with `Width + Height <= 1024` and up to 30 starting players.

- `-n/--name` sets the output file name; `-i/--internal-name` sets the map's
  internal `[Basic] Name` independently. Batch modes append `1,2...` to the
  file name and `01,02...` to the internal name. Quote values that contain
  spaces, e.g. `-i "Random City"`.
- `--players 30` places 30 players evenly around the four corners. If no size is
  given, the generator uses `500x500`; you can also pass e.g. `-w 512 -h 512`.
- Add `--spread-players` to distribute the players across the whole map instead
  of only along the edges, e.g.
  `--players 30 --spread-players -w 500 -h 400`.
- The legacy per-side options still work, e.g.
  `--nwp 8 --nep 8 --sep 7 --swp 7`. `N/S/W/E` remain limited to four players
  each; use the corner options or `--players` for larger counts. With
  `--spread-players`, the direction counts only determine the total.
- Extended maps use the 1024x1024 overlay layout required by VERA20K. The
  external CNCMaps renderer is skipped for them, but the in-map preview is
  still generated.

![map](使用方法.png)
![map](thumb_map.jpg)
![map](islands_map.jpg)


Acknowledgments
-------

Special thanks go out to authors of several modding tools that have greatly benefited the community as well as development of this program:

- planetarianPKU
- Olaf van der Spek for XCC and XWIS
- The OpenRA project
- All contributors to ModEnc
- The CNCMaps Renderer 's maker zzattack.


License
-------

The license below applies only to those parts of the program that do not contain a conflicting license placed at the top of the source file. These include parts from the OpenRA and XCC projects, which are licenced under the GPL v3.

(The MIT License)

Copyright (c) 2007-2013 Frank Razenberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the 'Software'), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
