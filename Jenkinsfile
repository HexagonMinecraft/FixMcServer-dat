pipeline {
  agent any
  stages {
    stage('install') {
      steps {
        sh '''wget -O is.exe http://files.jrsoftware.org/is/5/isetup-5.5.5.exe
innoextract is.exe
mkdir -p ~/".wine/drive_c/inno"
cp -a app/* ~/".wine/drive_c/inno"

/home/noah/.dotnet/dotnet restore'''
      }
    }
    stage('build'){
      step {
        sh '''dotnet publish -c release -r win10-x64
unset DISPLAY
wine "C:\inno\ISCC.exe" "setup_script.iss" "/q"
rm -r app/ tmp/ is.exe'''
      }
    }
  }
}
