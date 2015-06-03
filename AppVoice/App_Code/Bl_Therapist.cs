﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppVoice;

namespace AppVoice
{
    public class Bl_Therapist
    {
        Dal_Therapist dal_therapist;

        public Bl_Therapist()
        {
            dal_therapist = new Dal_Therapist();
        }

        /*  ****************************     Therapist     ****************************  */

        public bool isTherapistExists(int licenseId)        // check if therapist already exists
        {
            return dal_therapist.isTherapistExists(licenseId);
        }

        public SpeechTherapist therapistLogin(string licenseId, string password)   // return SpeechTherapist details when login using licensId and password. If user doesn't exist, return null.
        {
            return dal_therapist.therapistLogin(licenseId, password);
        }

        public SpeechTherapist getTherapistDetails(string licenseId)       // get therapist details
        {
            return dal_therapist.getTherapistDetails(licenseId);
        }

        public bool updateTherapistDetails(string licenseId, SpeechTherapist newTherapist)      // update details from therapist with 'licenseId' to 'newTherapist'
        {
            return dal_therapist.updateTherapistDetails(licenseId, newTherapist);
        }

        public bool updateTherapistPassword(string licenseId, string newPassword)       // update therapist pasword
        {
            return dal_therapist.updateTherapistPassword(licenseId, newPassword);
        }

        public bool isPasswordOkay(string licenseId, string password)
        {
            return dal_therapist.isPasswordOkay(licenseId, password);
        }

        /*  ****************************     Folder     ****************************  */

        public Folder getFolderDetails(int folderId)
        {
            return dal_therapist.getFolderDetails(folderId);
        }
        public List<Folder> getAllFolders(string therapistId)
        {
            return dal_therapist.getAllFolders(therapistId);
        }
        public bool addFolder(Folder folder)
        {
            return dal_therapist.addFolder(folder);
        }

        public bool updateDescriptionFolder(Folder folder, string description)
        {
            return dal_therapist.updateDescriptionFolder(folder, description);
        }

        public string getFolderNameByFolderId(int folderId, string therapistId)
        {
            return dal_therapist.getFolderNameByFolderId(folderId, therapistId);
        }

        public int getFolderIdByFolderName(string folderName, string therapistId)
        {
            return dal_therapist.getFolderIdByFolderName(folderName, therapistId);
        }

        public int getFolderIdByExerciseId(int exerciseId, string therapistId)
        {
            return dal_therapist.getFolderIdByExerciseId(exerciseId, therapistId);
        }

        /*  ****************************     Exercise     ****************************  */

        public List<Exercise> getAllExercisesByFolderId(string therapistId, int folderId)
        {
            return dal_therapist.getAllExercisesByFolderId(therapistId, folderId);
        }

        public List<Exercise> getAllExercises(string therapistId)
        {
            return dal_therapist.getAllExercises(therapistId);
        }

        public bool addExercise(Exercise exercise)
        {
            return dal_therapist.addExercise(exercise);
        }

        public Exercise getExerciseDetails(int exerciseId)
        {
            return dal_therapist.getExerciseDetails(exerciseId);
        }
        
        public bool updateDescriptionExercise(Exercise exercise, string description)
        {
            return dal_therapist.updateDescriptionExercise(exercise, description);
        }

        /*  ****************************     Task     ****************************  */

        public List<Task> getAllTasksByExerciseId(int exerciseId)
        {
            return dal_therapist.getAllTasksByExerciseId(exerciseId);
        }

        public bool addTask(Task task)
        {
            return dal_therapist.addTask(task);
        }

        /*  ****************************     Assignment Exercise     ****************************  */
        public bool addAssignmentExercise(AssignedExercise assignedExercise)
        {
            return dal_therapist.addAssignmentExercise(assignedExercise);
        }

        public List<AssignedExercise> getAllAssignedExercisesByTherapistId(string therapistId)      // get list of assigned exercises by therapist id
        {
            return dal_therapist.getAllAssignedExercisesByTherapistId(therapistId);
        }

        public List<AssignedExercise> getAllAssignedExercisesByPatientId(string patientId)      // get list of assigned exercises by patient id
        {
            return dal_therapist.getAllAssignedExercisesByPatientId(patientId);
        }

        public List<AssignedExercise> getAllAssignedExercisesByExerciseId(int exerciseId)       // get list of assigned exercises by exercise id
        {
            return dal_therapist.getAllAssignedExercisesByExerciseId(exerciseId);
        }
    }

}