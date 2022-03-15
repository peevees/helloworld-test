pipeline {
    agent {
       /*dockerfile true*/
       docker
       { 
           image 'mcr.microsoft.com/dotnet/runtime:6.0' 
       }
    }
    post {
    // trigger every time
    always {
      echo "====++++This will always be posted++++===="

    }
    // only triggered when build successful
    success {
      echo "====++++Build: Succeed++++===="

    }
    unstable {
      echo "====++++Build: Unstable++++===="
      
    }
    // triggered when red sign
    failure {
      echo "====++++Build: Failed++++===="
      
    }
    changed {
      echo "====++++Something has changed...++++===="
      
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
                sh "<path-to-xunit-executable> <path-to-project> --result=<path-to-testresults>
              },
              Nunit: {
                echo 'Run Nunit tests here'
                sh "<path-to-xunit-executable> <path-to-project> --result=<path-to-testresults>
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
