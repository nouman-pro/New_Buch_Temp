pipeline {
    agent any
    
      stages {
          stage('build') {
              steps {
                  echo 'building the software'
                 sh 'sudo dotnet build -c Release'
                 sh 'sudo dotnet publish'
                 
              }
          }

            stage('Deploying') {
              steps {
                  echo 'Deploying Project'               
                  echo 'copying files' 
sh 'sudo scp -r /home/jenkins/jenkins/workspace/intelihealth-dev-api/PRJ.API/bin/Release/net6.0/* xeven-frontend-apps@137.184.242.27:/var/www/intellihealthdevapi.xeventechnologies.com'
              }
          }

              
          stage('Restarting-service') {
              steps {
                  echo 'Restarting Service'
                  sh 'sudo ssh xeven-frontend-apps@137.184.242.27 sudo systemctl reload nginx.service'
                  sh 'sudo ssh xeven-frontend-apps@137.184.242.27 sudo systemctl restart intelihealthdevapi.service'
                
                 
              }
          }  
    }
       post {
             success {
                 emailext body: 'Changes successfully deployed. Please verify changes here! https://intellihealthdevapi.xeventechnologies.com/swagger/index.html', subject: '$PROJECT_NAME - Build # $BUILD_NUMBER - $BUILD_STATUS!', to: 'nouman.cool007@gmail.com'
                 emailext body: 'Changes successfully deployed. Please verify changes here! https://intellihealthdevapi.xeventechnologies.com/swagger/index.html', subject: '$PROJECT_NAME - Build # $BUILD_NUMBER - $BUILD_STATUS!', to: 'junaid@xevensolutions.com'
             }
             failure{
              emailext attachLog: true, body: 'Your Build failed to Deploy. Please check log Document! ', subject: '$PROJECT_NAME - Build # $BUILD_NUMBER - $BUILD_STATUS!', to: 'nouman.cool007@gmail.com'
              emailext attachLog: true, body: 'Your Build failed to deploy. Please check log document! ', subject: '$PROJECT_NAME - Build # $BUILD_NUMBER - $BUILD_STATUS!', to: 'junaid@xevensolutions.com'
          }
        }

}
