using System;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int examAssignments = 5;

// Student Names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames){
    string currentStudent = name;

    switch (currentStudent){
        case "Sophia":
            studentScores = sophiaScores;
            break;
        case "Andrew":
            studentScores = andrewScores;
            break;
        case "Emma":
            studentScores = emmaScores;
            break;
        case "Logan":
            studentScores = loganScores;
            break;
        case "Becky":
            studentScores = beckyScores;
            break;
        case "Chris":
            studentScores = chrisScores;
            break;
        case "Eric":
            studentScores = ericScores;
            break;
        case "Gregor":
            studentScores = gregorScores;
            break;
        default:
            continue;
    }

        // Initialize/reset the sum of scored assignments
        int sumAssignmentScores = 0;

        // Initialize/reset a counter for the number of assignment
        int gradedAssignment = 0;

        // Initialize/ reset the calculate average of exam + extra credit scores
        decimal currentStudentGrade = 0;

        foreach (int score in studentScores){

            // Increment the assignment counter
            gradedAssignment += 1;

            if (gradedAssignment <= examAssignments)
                // Add the exam score to the sum 
                sumAssignmentScores += score;

            else
                // Add the extra credit points to the sum - bonus points equal to 10% of an exam score
                sumAssignmentScores += score / 10;
        }
        
        currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

        switch (currentStudentGrade){
            case >= 97:
                currentStudentLetterGrade = "A+";
                break;
            case >= 93:
                currentStudentLetterGrade = "A";
                break;
            case >= 90:
                currentStudentLetterGrade = "A-";
                break;
            case >= 87:
                currentStudentLetterGrade = "B+";
                break;
            case >= 83:
                currentStudentLetterGrade = "B";
                break;
            case >= 80:
                currentStudentLetterGrade = "B-";
                break;
            case >= 77:
                currentStudentLetterGrade = "C+";
                break;
            case >= 73:
                currentStudentLetterGrade = "C";
                break;
            case >= 70:
                currentStudentLetterGrade = "C-";
                break;
            case >= 67:
                currentStudentLetterGrade = "D+";
                break;
            case >= 63:
                currentStudentLetterGrade = "D";
                break;
            case >= 60:
                currentStudentLetterGrade = "D-";
                break;
            default:
                currentStudentLetterGrade = "F";
                continue;
            }

        Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();