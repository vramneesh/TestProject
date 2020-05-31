pipeline {
	environment {
		solutionPath = "${workspace}\\TestProject.sln"
		serviceTestDll = "${workspace}\\TestProject\\bin\\Release\\TestProject.dll"
		nunitConsoleRunner = "${workspace}\\TestProject\\packages\\NUnit.ConsoleRunner.3.11.1\\tools\\nunit3-console.exe"
		reportDirectory = "${workspace}\\TestProject\\bin\\Release\\Reports"
	}
    agent any 
    stages {
		        stage('Pull Code') { 
            steps {
                script {
					git branch: 'master',
					credentialsId: 'GitHub',
					url: 'https://github.com/vramneesh/TestProject.git'
				}
            }
        }
	        stage('Restore') { 
            steps {
                powershell "NuGet.exe. restore ${solutionPath}"
            }
        }
        stage('Build') { 
            steps {
                powershell "MSBuild.exe ${solutionPath} /property:Configuration=Release"
            }
        }
        stage('Test') { 
            steps {
                powershell "& ${nunitConsoleRunner} ${serviceTestDll}"
            }
        }
    }
	post {
		always {
			publishHTML([
				allowMissing: false,
				alwaysLinkToLastBuild: false,
				keepAll: true,
				reportDir: "${reportDirectory}",
				reportFiles: "FeaturesReport.html",
				reportName: "HTML Report"
			])
		}
	}
}