#include "mainwindow.h"
#include "Scene.h"

#include<QWidget>
#include<QGraphicsScene>
#include <QGraphicsSceneMouseEvent>

void Scene::mousePressEvent(QGraphicsSceneMouseEvent *event) {
QGraphicsScene::mousePressEvent(event);
int x1 = event->pos().x();
int y1 = event->pos().y();
}

void Scene::mouseMoveEvent( QGraphicsSceneMouseEvent *event) {
QGraphicsScene::mouseMoveEvent(event);
int xNow = event->pos().x();
int yNow = event->pos().y();

}
