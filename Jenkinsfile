pipeline {
    agent any
    
    stages {
        stage('Restore NuGet Packages') {
            steps {
                echo "Restoring NuGet packages"
                bat "dotnet restore \"InoDayJenkins.sln\""
            }
        }
        
        stage('Build Api') {
            steps {
                echo "Building Api..."
                bat "dotnet build \"InoDayJenkins.sln\""
            }
        }
        
        stage('Publish Api') {
            steps {
                echo "Publishing Api..."
                bat "dotnet publish \"InoDayJenkins.sln\" -p:PublishProfile=FolderProfile"
            }
        }
        
        stage('Copy Build to Another Folder') {
            steps {
                script {
                    def branchName = env.GIT_BRANCH.replaceAll('/', '_') // Replaces '/' in branch name with '_' to create a valid directory name
                    def targetDirectory = "E:\\INetPub\\JekninsInnoDay\\ALBE"

                    echo "Removing previous build folder"
                    bat "if exist ${targetDirectory} rd /s /q ${targetDirectory}" // Remove the target directory if it exists
            
                    echo "Copying build to another folder"
                    bat "if not exist ${targetDirectory} mkdir ${targetDirectory}" // Create the target directory if it doesn't exist
                    bat "Xcopy \"\\Publish\\JenkinsInnoDay\\*.*" ${targetDirectory} /E /H /C /I"
            
                    // Update the target directory for the 'Move Files to Staging Server' stage
                    env.TARGET_DIRECTORY = targetDirectory
                }
            }
        }
    }
}
