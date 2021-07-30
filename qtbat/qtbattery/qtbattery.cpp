#include "qtbattery.h"
#include "ui_qtbattery.h"

qtbattery::qtbattery(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::qtbattery)
{
    ui->setupUi(this);
}

qtbattery::~qtbattery()
{
    delete ui;
}

