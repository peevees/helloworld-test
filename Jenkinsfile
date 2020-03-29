pipeline {
    agent {
       /*dockerfile true*/
       docker
       { 
           image 'mcr.microsoft.com/dotnet/core/sdk:2.2-stretch' 
       }
    }
    post {
    // trigger every time
    always {
      echo "====++++This will always be posted++++===="
      hello 'John'
    }
    // only triggered when build successful
    success {
      echo "====++++Build: Succeed++++===="

      //TODO: add coverage archive testresults
      //archiveArtifacts artifacts:"**/TestsResults/*TestResults.xml"

      //def files = findFiles glob: '**/TestsResults/*.xml'
      //boolean exists = files.length > 0
      //if (exists){
      //  publishTestResults()
      //}else{
      //  echo "====++++No TestResults found++++===="
      //}
      //Send slack notification
      //slackNotificationSender("*${currentBuild.currentResult}:*, "Succcesfull")
    }
    unstable {
      echo "====++++Build: Unstable++++===="
      //def files = findFiles glob: '**/TestsResults/*.xml'
      // boolean exists = files.length > 0
      // if (exists){
      //   publishTestResults()
      // }else{
      //   echo "====++++No TestResults found++++===="
      // }
      // slackNotificationSender(currentBuild.result, "Unstable")
      //slackNotifier(buildStatus: currentBuild.result, msg: "unstable")
    }
    // triggered when red sign
    failure {
      echo "====++++Build: Failed++++===="
      // def files = findFiles glob: '**/TestsResults/*.xml'
      // boolean exists = files.length > 0
      // if (exists){
      //   publishTestResults()
      // }else{
      //   echo "====++++No TestResults found++++===="
      // }
      // slackNotificationSender(currentBuild.result, "Failed")
      //slackNotifier(buildStatus: currentBuild.result, msg: "failure")
    }
    changed {
      echo "====++++Something has changed...++++===="
      // def files = findFiles glob: '**/TestsResults/*.xml'
      // boolean exists = files.length > 0
      // if (exists){
      //   publishTestResults()
      // }else{
      //   echo "====++++No TestResults found++++===="
      // }
      // slackNotificationSender(currentBuild.result, "Changed")
    }
  }
    stages {
     stage('Restore') {
       options {
          timeout(time: 1, unit: 'HOURS') 
        }
            steps {
                echo 'Restoring..'
                sh 'dotnet restore'
            }
        }
      stage('Build') {
        options {
          timeout(time: 1, unit: 'HOURS') 
        }
          steps {
              echo 'Building..'
              sh 'dotnet build'
              sh 'dotnet clean'
          }
      }
      stage('Test') {
          steps {
            parallel(
              echo 'Testing..'
              sh 'dotnet test'
              MSTest: {
                echo 'Run mstest tests here'
                sh 'dotnet test'
              },
              Xunit: {
                echo 'Run Xunit Tests here'
                sh "<path-to-xunit-executable> <path-to-project> --result=\"TestsResults/WebSiteTestResults.xml\""
              },
              Nunit: {
                echo 'Run Nunit tests here'
                sh "src/packages/NUnit.ConsoleRunner.3.10.0/tools/nunit3-console.exe <path-to-project> --result=\"TestsResults/WebSiteTestResults.xml\""
              }
            )
          }
      }
      stage('Publish') {
          steps {
              echo 'Publishing....'
              sh 'dotnet publish -c release -r ubuntu-x64 --self-contained=true'
          }
      }
    }
}