funcs.o : funcs.cpp funcs.h
	<tab> g++ -c lab01.cpp

lab01.o : lab01.cpp funcs.h
	<tab> g++ -c lab01.cpp
# Linking of object files

Lab01 : lab01.o funcs.o
	<tab> g++ lab01.o funcs.o -o lab01
# Clean all object files and executables
	
clean :
	<tab> rm -f *.o lab01
