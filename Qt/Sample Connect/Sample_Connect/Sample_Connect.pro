#-------------------------------------------------
#
# Project created by QtCreator 2012-05-06T18:59:31
#
#-------------------------------------------------

QT       += core gui 
greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = Sample_Connect
TEMPLATE = app

SOURCES += main.cpp\
        mainwindow.cpp

HEADERS  += mainwindow.h

FORMS    += mainwindow.ui

win32: LIBS += -L$$PWD/../../../libraries/bin/qt/win/ -lqkclmtr
macx: LIBS += -L$$PWD/../../../libraries/bin/qt/mac/ -lqkclmtr
unix:!macx:!symbian: LIBS += -L$$PWD/../../../libraries/bin/qt/unix/ -lqkclmtr

INCLUDEPATH += $$PWD/../../../libraries/bin/headers/
DEPENDPATH += $$PWD/../../../libraries/bin/headers/

win32: PRE_TARGETDEPS += $$PWD/../../../libraries/bin/qt/win/qkclmtr.lib
macx: PRE_TARGETDEPS += $$PWD/../../../libraries/bin/qt/mac/libqkclmtr.a
unix:!macx:!symbian: PRE_TARGETDEPS += $$PWD/../../../libraries/bin/qt/unix/libqkclmtr.a
