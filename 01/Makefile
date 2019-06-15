CC = gcc
CFLAGS = -Wall -O2
CPP = g++
CPPFLAGS = -Wall -O2
OBJS = glad.o main.o
TARGET = main
ifeq ($(shell uname), Linux)
LIBS = -lglfw3 -lGL -lX11 -lpthread -lXrandr -lXi -ldl
else
LIBS = -lglfw3 -framework Cocoa -framework OpenGL -framework IOKit -framework CoreVideo -framework Carbon
endif
INCLUDE_DIR = include

.SUFFIXES: .c .cpp .o

.PHONY: all
all: $(TARGET)

$(TARGET): $(OBJS)
	$(CPP) -o $(TARGET) $^ -I $(INCLUDE_DIR) $(LIBS)


.c.o:
	$(CC) $(CFLAGS) -c $< -I $(INCLUDE_DIR) $(LIBS)
.cpp.o:
	$(CPP) $(CPPFLAGS) -c $< -I $(INCLUDE_DIR) $(LIBS)

.PHONY: clean
clean:
	$(RM) $(TARGET) $(OBJS)