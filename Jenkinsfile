pipeline {
    agent any
    
        stage('Restore NuGet Packages') {
            steps {
                echo "Restoring NuGet packages"
                bat "dotnet restore InoDayJenkins.sln"
            }
        }
        
        stage('Build Api') {
            steps {
                echo "Building Api..."
                bat "\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\MSBuild\\Current\\Bin\\msbuild.exe\" \"InoDayJenkins.sln\" /p:DeployOnBuild=true"
            }
        }
        
        stage('Copy Build to Another Folder') {
            steps {
                script {
                    def branchName = env.GIT_BRANCH.replaceAll('/', '_') // Replaces '/' in branch name with '_' to create a valid directory name
                    def targetDirectory = "E:\\Build\\${branchName}"

                    echo "Removing previous build folder"
                    bat "if exist ${targetDirectory} rd /s /q ${targetDirectory}" // Remove the target directory if it exists
            
                    echo "Copying build to another folder"
                    bat "if not exist ${targetDirectory} mkdir ${targetDirectory}" // Create the target directory if it doesn't exist
                    bat "Xcopy %WORKSPACE%\\Publish\\RenoWeb.Web ${targetDirectory} /E /H /C /I"
            
                    // Update the target directory for the 'Move Files to Staging Server' stage
                    env.TARGET_DIRECTORY = targetDirectory
                }
            }
        }
    }
}
