#pragma once

#include <QGraphicsScene>
#include <QWidget>

#include "mainwindow.h"

#ifndef SCENEMAIN_H
#define SCENEMAIN_H

#endif // SCENEMAIN_H

class Scene : public QGraphicsScene
{
    Q_OBJECT

public:
    virtual void mousePressEvent(QGraphicsSceneMouseEvent *event);
    virtual void mouseReleaseEvent(QGraphicsSceneMouseEvent *event);
    virtual void mouseMoveEvent( QGraphicsSceneMouseEvent *event);
}
