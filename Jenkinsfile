pipeline {
  agent any
  stages {
    stage('install') {
      steps {
        sh '''add-apt-repository ppa:likemartinma/osslsigncode --yes
dpkg --add-architecture i386
apt-get update
apt-get install -y -q innoextract wine python-software-properties osslsigncode
wget -O is.exe http://files.jrsoftware.org/is/5/isetup-5.5.5.exe
innoextract is.exe
mkdir -p ~/".wine/drive_c/inno"
cp -a app/* ~/".wine/drive_c/inno"'''
      }
    }
  }
}