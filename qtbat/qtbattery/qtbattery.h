#ifndef QTBATTERY_H
#define QTBATTERY_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui { class qtbattery; }
QT_END_NAMESPACE

class qtbattery : public QMainWindow
{
    Q_OBJECT

public:
    qtbattery(QWidget *parent = nullptr);
    ~qtbattery();

private:
    Ui::qtbattery *ui;
};
#endif // QTBATTERY_H
