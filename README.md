# PoP - Assignment 7
PoP - 7g

Don't be stupid...

# PoP - 7g


## Kode


Biblioteket compiles med fsharpc;

	$ fsharpc -a rotate.fsi rotate.fs


Nu compiles testsne og "game" med fsharpc og køres med mono;

	$ fsharpc -r rotate.dll blackboxtest.fsx
	$ fsharpc -r rotate.dll whiteboxtest.fsx
	$ fsharpc -r rotate.dll game.fsx
	$ mono blackboxtest.exe
	$ mono whiteboxtest.exe
	$ mono game.exe


rotate.fsi compiles til XML med fsharpc;

	$ fsharpc --doc:rotate.xml -a rotate.fsi rotate.fs
