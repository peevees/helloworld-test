pipeline {
    agent {
       /*dockerfile true*/
       docker
       { 
           image 'mcr.microsoft.com/dotnet/core/runtime:2.2-stretch-slim'
           args '-u root:root' 
       
       }
    }
    stages {
     stage('Restore') {
            steps {
                echo 'Restoring..'
                sh 'dotnet restore'
            }
        }
        stage('Build') {
            steps {
                echo 'Building..'
                sh 'dotnet build'
                sh 'dotnet clean'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
                sh 'dotnet test'
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