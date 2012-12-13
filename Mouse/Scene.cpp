#include "mainwindow.h"
#include "Scene.h"

#include<QWidget>
#include<QGraphicsScene>
#include <QGraphicsSceneMouseEvent>

float Scene::changeX(float x) {
    float newX;
    if(newX != NULL) {
        return newX;
    }
    else {
        newX = x;
    }

}

float Scene::changeY(float y) {
    float newY;
    if(newY != NULL) {
        return newY;
    }
    else {
        newY = y;
    }

}

void Scene::mousePressEvent(QGraphicsSceneMouseEvent *event) {
QGraphicsScene::mousePressEvent(event);
float x1 = event->pos().x();
float y1 = event->pos().y();
changeX(x1);
changeY(y1);
}

void Scene::mouseMoveEvent( QGraphicsSceneMouseEvent *event) {
QGraphicsScene::mouseMoveEvent(event);
float xNow = event->pos().x();
float yNow = event->pos().y();
float xBefore = changeX(xNow);
float yBefore = changeY(yNow);
this->addLine(xBefore,yBefore,xNow,yNow,QPen(Qt::black));

}

void Scene::mouseReleaseEvent(QGraphicsSceneMouseEvent *event) {
QGraphicsScene::mouseReleaseEvent(event);
}
