#include "Head.h"
#include "ui_MainForm(window).h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
//    float aa = ui->lblVakueSPB1->text().toFloat();
    delete ui;
}

void MainWindow::showIt(float c)
{
    QString answer = QString::number(c);
    ui->lblAnswer->setText(answer);
}

void MainWindow::on_cmbOne_currentIndexChanged(const QString &arg1)
{

    float a = ui->spbOne->value();
    float b = ui->spbTwo->value();
    float c = 0;
    if (arg1 == "+") {
        c = a + b;
    }
    else {
        if (arg1 == "-") {
            c = a - b;
        }
        else {
            if (arg1 == "*") {
                c = a * b;
            }
            else c = a / b;
        }
    }
    showIt(c);
}


void MainWindow::on_spbOne_valueChanged(int arg1)
{
    float a = arg1;
    float b = ui->spbTwo->value();
    float c = 0;
    if (ui->cmbOne->currentText() == "+") {
        c = a + b;
    }
    else {
        if (ui->cmbOne->currentText() == "-") {
            c = a - b;
        }
        else {
            if (ui->cmbOne->currentText() == "*") {
                c = a * b;
            }
            else c = a / b;
        }
    }
    showIt(c);
}

void MainWindow::on_spbTwo_valueChanged(int arg1)
{
    float a = ui->spbOne->value();
    float b = arg1;
    float c = 0;
    if (ui->cmbOne->currentText() == "+") {
        c = a + b;
    }
    else {
        if (ui->cmbOne->currentText() == "-") {
            c = a - b;
        }
        else {
            if (ui->cmbOne->currentText() == "*") {
                c = a * b;
            }
            else c = a / b;
        }
    }
    showIt(c);
}
