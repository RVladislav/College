#pragma

#include <QMainWindow>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT
    
public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    void showIt(float c);

private slots:
    void on_cmbOne_currentIndexChanged(const QString &arg1);

    void on_spbOne_valueChanged(int arg1);

    void on_spbTwo_valueChanged(int arg1);

private:
    Ui::MainWindow *ui;
};
