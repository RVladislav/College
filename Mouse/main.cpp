#include <QApplication>

#include <QGraphicsScene>
#include <QGraphicsView>
#include <QWidget>

#include "mainwindow.h"


int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;
    w.show();

    QGraphicsScene scene;
    scene.setSceneRect( -100.0, -100.0, 200.0, 200.0 );


    QGraphicsView scene_view(&scene);
    scene_view.setRenderHints(QPainter::Antialiasing);
    scene_view.show();

    return a.exec();
}
//void QWidget::mouseMoveEvent ( QMouseEvent * event )
//{
//    int x = pos.x();
//    int y = pos.y();
//}
