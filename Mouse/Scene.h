#pragma once

#include<QWidget>
#include<QGraphicsScene>

#include"mainwindow.h"

#ifndef SCENE_H
#define SCENE_H

#endif // SCENE_H

class Scene : public QGraphicsScene
{
    Q_OBJECT
public:
    float changeX(float xPoint);
    float changeY(float yPoint);
private:
    virtual void mousePressEvent(QGraphicsSceneMouseEvent *event);
    virtual void mouseReleaseEvent(QGraphicsSceneMouseEvent *event);
    virtual void mouseMoveEvent( QGraphicsSceneMouseEvent *event);

};
