/********************************************************************************
** Form generated from reading UI file 'qtbattery.ui'
**
** Created by: Qt User Interface Compiler version 5.12.8
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_QTBATTERY_H
#define UI_QTBATTERY_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenu>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QProgressBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_qtbattery
{
public:
    QAction *actionCharge;
    QAction *actionDischarge;
    QAction *actionExit;
    QWidget *centralwidget;
    QWidget *horizontalLayoutWidget;
    QHBoxLayout *horizontalLayout;
    QLabel *label;
    QTextEdit *textport;
    QCheckBox *cbopen;
    QWidget *horizontalLayoutWidget_2;
    QHBoxLayout *horizontalLayout_2;
    QLabel *label_2;
    QTextEdit *textmin;
    QLabel *label_3;
    QTextEdit *textmax;
    QLabel *label_4;
    QProgressBar *progressBar;
    QMenuBar *menubar;
    QMenu *menuFile;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *qtbattery)
    {
        if (qtbattery->objectName().isEmpty())
            qtbattery->setObjectName(QString::fromUtf8("qtbattery"));
        qtbattery->resize(400, 225);
        QSizePolicy sizePolicy(QSizePolicy::Fixed, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(qtbattery->sizePolicy().hasHeightForWidth());
        qtbattery->setSizePolicy(sizePolicy);
        qtbattery->setMaximumSize(QSize(400, 225));
        actionCharge = new QAction(qtbattery);
        actionCharge->setObjectName(QString::fromUtf8("actionCharge"));
        actionDischarge = new QAction(qtbattery);
        actionDischarge->setObjectName(QString::fromUtf8("actionDischarge"));
        actionExit = new QAction(qtbattery);
        actionExit->setObjectName(QString::fromUtf8("actionExit"));
        centralwidget = new QWidget(qtbattery);
        centralwidget->setObjectName(QString::fromUtf8("centralwidget"));
        horizontalLayoutWidget = new QWidget(centralwidget);
        horizontalLayoutWidget->setObjectName(QString::fromUtf8("horizontalLayoutWidget"));
        horizontalLayoutWidget->setGeometry(QRect(20, 20, 351, 31));
        horizontalLayout = new QHBoxLayout(horizontalLayoutWidget);
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        horizontalLayout->setContentsMargins(0, 0, 0, 0);
        label = new QLabel(horizontalLayoutWidget);
        label->setObjectName(QString::fromUtf8("label"));

        horizontalLayout->addWidget(label);

        textport = new QTextEdit(horizontalLayoutWidget);
        textport->setObjectName(QString::fromUtf8("textport"));

        horizontalLayout->addWidget(textport);

        cbopen = new QCheckBox(horizontalLayoutWidget);
        cbopen->setObjectName(QString::fromUtf8("cbopen"));

        horizontalLayout->addWidget(cbopen);

        horizontalLayoutWidget_2 = new QWidget(centralwidget);
        horizontalLayoutWidget_2->setObjectName(QString::fromUtf8("horizontalLayoutWidget_2"));
        horizontalLayoutWidget_2->setGeometry(QRect(20, 60, 351, 31));
        horizontalLayout_2 = new QHBoxLayout(horizontalLayoutWidget_2);
        horizontalLayout_2->setObjectName(QString::fromUtf8("horizontalLayout_2"));
        horizontalLayout_2->setContentsMargins(0, 0, 0, 0);
        label_2 = new QLabel(horizontalLayoutWidget_2);
        label_2->setObjectName(QString::fromUtf8("label_2"));

        horizontalLayout_2->addWidget(label_2);

        textmin = new QTextEdit(horizontalLayoutWidget_2);
        textmin->setObjectName(QString::fromUtf8("textmin"));

        horizontalLayout_2->addWidget(textmin);

        label_3 = new QLabel(horizontalLayoutWidget_2);
        label_3->setObjectName(QString::fromUtf8("label_3"));

        horizontalLayout_2->addWidget(label_3);

        textmax = new QTextEdit(horizontalLayoutWidget_2);
        textmax->setObjectName(QString::fromUtf8("textmax"));

        horizontalLayout_2->addWidget(textmax);

        label_4 = new QLabel(centralwidget);
        label_4->setObjectName(QString::fromUtf8("label_4"));
        label_4->setGeometry(QRect(20, 110, 171, 17));
        progressBar = new QProgressBar(centralwidget);
        progressBar->setObjectName(QString::fromUtf8("progressBar"));
        progressBar->setGeometry(QRect(20, 140, 351, 31));
        progressBar->setValue(24);
        qtbattery->setCentralWidget(centralwidget);
        menubar = new QMenuBar(qtbattery);
        menubar->setObjectName(QString::fromUtf8("menubar"));
        menubar->setGeometry(QRect(0, 0, 400, 22));
        menuFile = new QMenu(menubar);
        menuFile->setObjectName(QString::fromUtf8("menuFile"));
        qtbattery->setMenuBar(menubar);
        statusbar = new QStatusBar(qtbattery);
        statusbar->setObjectName(QString::fromUtf8("statusbar"));
        qtbattery->setStatusBar(statusbar);

        menubar->addAction(menuFile->menuAction());
        menuFile->addAction(actionCharge);
        menuFile->addAction(actionDischarge);
        menuFile->addAction(actionExit);

        retranslateUi(qtbattery);

        QMetaObject::connectSlotsByName(qtbattery);
    } // setupUi

    void retranslateUi(QMainWindow *qtbattery)
    {
        qtbattery->setWindowTitle(QApplication::translate("qtbattery", "Battery Control", nullptr));
        actionCharge->setText(QApplication::translate("qtbattery", "Charge", nullptr));
        actionDischarge->setText(QApplication::translate("qtbattery", "Discharge", nullptr));
        actionExit->setText(QApplication::translate("qtbattery", "Exit", nullptr));
        label->setText(QApplication::translate("qtbattery", "Port", nullptr));
        textport->setPlaceholderText(QApplication::translate("qtbattery", "/dev/ttyUSB0", nullptr));
        cbopen->setText(QApplication::translate("qtbattery", "Open", nullptr));
        label_2->setText(QApplication::translate("qtbattery", "Min", nullptr));
        textmin->setDocumentTitle(QString());
        textmin->setPlaceholderText(QApplication::translate("qtbattery", "57.5", nullptr));
        label_3->setText(QApplication::translate("qtbattery", "Max", nullptr));
        textmax->setPlaceholderText(QApplication::translate("qtbattery", "62.5", nullptr));
        label_4->setText(QApplication::translate("qtbattery", "Battery percentage (%)", nullptr));
        menuFile->setTitle(QApplication::translate("qtbattery", "File", nullptr));
    } // retranslateUi

};

namespace Ui {
    class qtbattery: public Ui_qtbattery {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_QTBATTERY_H
