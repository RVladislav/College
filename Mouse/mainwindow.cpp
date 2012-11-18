#include "mainwindow.h"
#include "ui_mainwindow.h"

#include <QWidget>

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

void MainWindow::on_graphOne_customContextMenuRequested(const QPoint &pos)
{
    //Захват координат и добавление в массив координат
    int const n = 10000;
    int arrayX[n], arrayY[n];
    for(int i = 0;i<n;i++)
    {
        arrayX[i]=pos.x();
        arrayY[i]=pos.y();
    }
    for(int i = 0;i<n;i++)
    {
        int x = pos.x();
        int y = pos.y();
        if(x==arrayX[i] && y==arrayY[i])
        {
            //Замкнутость
        }
    }
}
void QWidget::moveEvent ( QMoveEvent * event )
{

    //Отрисовка пути
}
