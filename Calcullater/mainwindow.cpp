#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{

    delete ui;
}

void MainWindow::showIt(float c)
{
    QString answer = QString::number(c);
    ui->lblAnswer->setText(answer);
}

void MainWindow::on_cmbOne_currentIndexChanged(const QString &arg1)
{
    float a = ui->spbOne->value()
            ,b = ui->spbTwo->value()
            ,c = 0;
    if(arg1=="+"){
        c = a + b;
    }
    if(arg1=="-"){
        c = a - b;
    }
    if(arg1=="*"){
     c = a * b;
    }
    if(arg1=="/"){
     c = a / b;
    }
    showIt(c);
}


void MainWindow::on_spbOne_valueChanged(int arg1)
{
    float a = arg1
            ,b = ui->spbTwo->value()
            , c = 0;
    if(ui->cmbOne->currentText()=="+") {
        c = a + b;
    }
    if(ui->cmbOne->currentText()=="-") {
        c = a - b;
    }
    if(ui->cmbOne->currentText()=="*") {
        c = a * b;
    }
    if(ui->cmbOne->currentText()=="/") {
        c = a / b;
    }
    showIt(c);
}

void MainWindow::on_spbTwo_valueChanged(int arg1)
{
    float a = ui->spbOne->value()
            ,b = arg1
            , c = 0;
    if(ui->cmbOne->currentText()=="+") {
        c = a + b;
    }
    if(ui->cmbOne->currentText()=="-") {
        c = a - b;
    }
    if(ui->cmbOne->currentText()=="*") {
        c = a * b;
    }
    if(ui->cmbOne->currentText()=="/") {
        c = a / b;
    }
    showIt(c);
}
