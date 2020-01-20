#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow){
    ui->setupUi(this);
}

MainWindow::~MainWindow(){
    delete ui;
}

void MainWindow::on_pushButton_clicked(){
    kclmtr.setPort(ui->linePort->text());
}

void MainWindow::on_pushButton_2_clicked(){
    if(kclmtr.connect()){
        QMessageBox::warning(this, "Measurement Error", "Port is open");
    }else{
        QMessageBox::warning(this, "Measurement Error", "Port is not open");
    }
}

void MainWindow::on_pushButton_3_clicked(){
    if(kclmtr.isPortOpen()){
        Measurement measurement = kclmtr.getNextMeasurement(1);
        if(KleinsErrorCodes::shouldStopMeasuring(measurement.getErrorCode())) {
			kclmtr.stopMeasuring();
            QMessageBox::warning(this, "Measurement Error",
                                KleinsErrorCodes::errorCodesToString(measurement.getErrorCode()), QMessageBox::Ok, QMessageBox::NoButton);
		} else {
            ui->lineEdit_x->setText(QString("%1").arg(measurement.getCIE1931_x()));
            ui->lineEdit_y->setText(QString("%1").arg(measurement.getCIE1931_y()));
            ui->lineEdit_l->setText(QString("%1").arg(measurement.getBigY()));
        }
    }else{
        QMessageBox::warning(this, "Measurement Error", "Port is not open");
    }
}
