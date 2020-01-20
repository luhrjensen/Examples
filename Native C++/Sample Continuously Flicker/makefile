KClmtrLib = ../../libraries/bin/native\ c++/g++/libKClmtr.a

CC = g++
CFlags = -g -Wall -pthread
INCLUDES = ../../libraries/bin/headers/KClmtr.h

all: main

main:
	$(CC) $(CFlags) -o out main.cpp $(KClmtrLib)

clean:
	rm -f *.o
	rm -f out
