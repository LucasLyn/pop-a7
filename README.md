# PoP - Assignment 7
PoP - 7g

This assignment was about a rotation based puzzle game. We were tasked with creating the game from the ground up.

# PoP - 7g


## Kode


The library is compiled with fsharpc;

	$ fsharpc -a rotate.fsi rotate.fs


The code is compiled with the library with fsharpc and run with mono;

	$ fsharpc -r rotate.dll blackboxtest.fsx
	$ fsharpc -r rotate.dll whiteboxtest.fsx
	$ fsharpc -r rotate.dll game.fsx
	$ mono blackboxtest.exe
	$ mono whiteboxtest.exe
	$ mono game.exe


The library is compiled to XML with fsharpc;

	$ fsharpc --doc:rotate.xml -a rotate.fsi rotate.fs
