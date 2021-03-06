# Els_kom_new

![Els_kom Icon](https://github.com/Elskom/Els_kom_new/blob/icon/els_kom.png)

|       | Build |
|:---------------:  |:---------------:  |
| Master: | [![Build status](https://ci.appveyor.com/api/projects/status/5ikdee6h3qy6lyum/branch/master?svg=true)](https://ci.appveyor.com/project/AraHaan/els-kom-new) |
| Current: | [![Build status](https://ci.appveyor.com/api/projects/status/5ikdee6h3qy6lyum?svg=true)](https://ci.appveyor.com/project/AraHaan/els-kom-new) |

This is a version of Els_kom for Elsword and Grand Chase KOM Files.

## To Build

1. Run ``git clone https://github.com/Elskom/Els_kom_new.git``. Do not download the master branch as a zip file or build might fail or crash Visual Studio 2017.
2. Run:
```cmd
git clone https://github.com/Elskom/newsmake.git
cd newsmake/build
cmake ..
msbuild newsmake.sln /p:Configuration=Release /p:Platform="Win32" /nologo /verbosity:m /m
cd ../../Misc/NEWS
"../../newsmake/build/Release/newsmake"
cd ../..
```

To build the changelog (optional but recommended). Make sure that msbuild from your VS2017 install is in your global path environment variable first before these commands.

3. Open the ``PCbuild/pcbuild.sln`` solution file in Visual Studio 2017 and then select ``Release``, ``x86`` and hit ``Build Solution``. Alternatively you can use the same msbuild command above but change ``Win32`` to ``x86``, and ``newsmake.sln`` to ``PCbuild/pcbuild.sln``.
4. Get a cup of Tea. Build might take a bit.
