pipeline {
    agent {
       dockerfile true
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