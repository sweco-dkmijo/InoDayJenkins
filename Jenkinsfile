pipeline {
  agent any
  stages {
    
    stage('Nuget Restore') {
      steps {
          echo 'Restore'
          bat 'dotnet restore'
      }
    }

    stage('Build') {
      steps {
        script {
            echo "Building project"
            bat "dotnet build"
            }
        }
    }

    stage('Test') {
      steps {
        script {
            echo "Testing project"
            bat "dotnet test"
            }
        }
    }

    stage('Publish') {
      steps {
        script {
            echo "Publishing project"
            bat "dotnet publish -c Release -o out/"
            }
        }
    }

    stage('Deploy') {
      steps {
        script {
          echo "Deploying files to deploy target"
          bat "move out\\* E:\\INetPub\\JekninsInnoDay\\CAHE\\"
          }
        }
    }
  }
}
