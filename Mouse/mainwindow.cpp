#include "mainwindow.h"
#include "Scene.h"
#include "ui_mainwindow.h"

#include<QWidget>
#include<QGraphicsScene>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    QGraphicsScene Myscene = new QGraphicsScene();

        QGraphicsView scene_view(&Myscene);
        scene_view.setRenderHints(QPainter::Antialiasing);
        scene_view.setMaximumHeight(300);
        scene_view.setMaximumWidth(300);
        ui->graphOne->setScene(&Myscene);

    delete ui;
}



