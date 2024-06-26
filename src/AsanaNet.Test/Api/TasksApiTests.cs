/*
 * Asana
 *
 * This is the interface for interacting with the [Asana Platform](https://developers.asana.com). Our API reference is generated from our [OpenAPI spec] (https://raw.githubusercontent.com/Asana/openapi/master/defs/asana_oas.yaml).
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using AsanaNet.Client;
using AsanaNet.Api;
// uncomment below to import models
//using AsanaNet.Model;

namespace AsanaNet.Test.Api
{
    /// <summary>
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TasksApiTests : IDisposable
    {
        private TasksApi instance;

        public TasksApiTests()
        {
            instance = new TasksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TasksApi
            //Assert.IsType<TasksApi>(instance);
        }

        /// <summary>
        /// Test AddDependenciesForTask
        /// </summary>
        [Fact]
        public void AddDependenciesForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependenciesForTaskRequest addDependenciesForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.AddDependenciesForTask(taskGid, addDependenciesForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test AddDependentsForTask
        /// </summary>
        [Fact]
        public void AddDependentsForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependentsForTaskRequest addDependentsForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.AddDependentsForTask(taskGid, addDependentsForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test AddFollowersForTask
        /// </summary>
        [Fact]
        public void AddFollowersForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddFollowersRequest addFollowersRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.AddFollowersForTask(taskGid, addFollowersRequest, optPretty, optFields);
            //Assert.IsType<CreateTask201Response>(response);
        }

        /// <summary>
        /// Test AddProjectForTask
        /// </summary>
        [Fact]
        public void AddProjectForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddProjectForTaskRequest addProjectForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.AddProjectForTask(taskGid, addProjectForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test AddTagForTask
        /// </summary>
        [Fact]
        public void AddTagForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddTagForTaskRequest addTagForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.AddTagForTask(taskGid, addTagForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test CreateSubtaskForTask
        /// </summary>
        [Fact]
        public void CreateSubtaskForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //CreateTaskRequest createTaskRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.CreateSubtaskForTask(taskGid, createTaskRequest, optPretty, optFields);
            //Assert.IsType<CreateTask201Response>(response);
        }

        /// <summary>
        /// Test CreateTask
        /// </summary>
        [Fact]
        public void CreateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTaskRequest createTaskRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.CreateTask(createTaskRequest, optPretty, optFields);
            //Assert.IsType<CreateTask201Response>(response);
        }

        /// <summary>
        /// Test DeleteTask
        /// </summary>
        [Fact]
        public void DeleteTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //var response = instance.DeleteTask(taskGid, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test DuplicateTask
        /// </summary>
        [Fact]
        public void DuplicateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //DuplicateTaskRequest duplicateTaskRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.DuplicateTask(taskGid, duplicateTaskRequest, optPretty, optFields);
            //Assert.IsType<GetJob200Response>(response);
        }

        /// <summary>
        /// Test GetDependenciesForTask
        /// </summary>
        [Fact]
        public void GetDependenciesForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetDependenciesForTask(taskGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test GetDependentsForTask
        /// </summary>
        [Fact]
        public void GetDependentsForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetDependentsForTask(taskGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test GetSubtasksForTask
        /// </summary>
        [Fact]
        public void GetSubtasksForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetSubtasksForTask(taskGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test GetTask
        /// </summary>
        [Fact]
        public void GetTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.GetTask(taskGid, optPretty, optFields);
            //Assert.IsType<CreateTask201Response>(response);
        }

        /// <summary>
        /// Test GetTaskForCustomID
        /// </summary>
        [Fact]
        public void GetTaskForCustomIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceGid = null;
            //string customId = null;
            //var response = instance.GetTaskForCustomID(workspaceGid, customId);
            //Assert.IsType<CreateTask201Response>(response);
        }

        /// <summary>
        /// Test GetTasks
        /// </summary>
        [Fact]
        public void GetTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //string? assignee = null;
            //string? project = null;
            //string? section = null;
            //string? workspace = null;
            //DateTime? completedSince = null;
            //DateTime? modifiedSince = null;
            //List<string>? optFields = null;
            //var response = instance.GetTasks(optPretty, limit, offset, assignee, project, section, workspace, completedSince, modifiedSince, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test GetTasksForProject
        /// </summary>
        [Fact]
        public void GetTasksForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //string? completedSince = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetTasksForProject(projectGid, completedSince, optPretty, limit, offset, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test GetTasksForSection
        /// </summary>
        [Fact]
        public void GetTasksForSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sectionGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //string? completedSince = null;
            //List<string>? optFields = null;
            //var response = instance.GetTasksForSection(sectionGid, optPretty, limit, offset, completedSince, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test GetTasksForTag
        /// </summary>
        [Fact]
        public void GetTasksForTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetTasksForTag(tagGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test GetTasksForUserTaskList
        /// </summary>
        [Fact]
        public void GetTasksForUserTaskListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userTaskListGid = null;
            //string? completedSince = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetTasksForUserTaskList(userTaskListGid, completedSince, optPretty, limit, offset, optFields);
            //Assert.IsType<GetTasks200Response>(response);
        }

        /// <summary>
        /// Test RemoveDependenciesForTask
        /// </summary>
        [Fact]
        public void RemoveDependenciesForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependenciesForTaskRequest addDependenciesForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.RemoveDependenciesForTask(taskGid, addDependenciesForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test RemoveDependentsForTask
        /// </summary>
        [Fact]
        public void RemoveDependentsForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependentsForTaskRequest addDependentsForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.RemoveDependentsForTask(taskGid, addDependentsForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test RemoveFollowerForTask
        /// </summary>
        [Fact]
        public void RemoveFollowerForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //RemoveFollowerForTaskRequest removeFollowerForTaskRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.RemoveFollowerForTask(taskGid, removeFollowerForTaskRequest, optPretty, optFields);
            //Assert.IsType<CreateTask201Response>(response);
        }

        /// <summary>
        /// Test RemoveProjectForTask
        /// </summary>
        [Fact]
        public void RemoveProjectForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //RemoveProjectForTaskRequest removeProjectForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.RemoveProjectForTask(taskGid, removeProjectForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test RemoveTagForTask
        /// </summary>
        [Fact]
        public void RemoveTagForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //RemoveTagForTaskRequest removeTagForTaskRequest = null;
            //bool? optPretty = null;
            //var response = instance.RemoveTagForTask(taskGid, removeTagForTaskRequest, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test SearchTasksForWorkspace
        /// </summary>
        [Fact]
        public void SearchTasksForWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceGid = null;
            //bool? optPretty = null;
            //string? text = null;
            //string? resourceSubtype = null;
            //string? assigneeAny = null;
            //string? assigneeNot = null;
            //string? portfoliosAny = null;
            //string? projectsAny = null;
            //string? projectsNot = null;
            //string? projectsAll = null;
            //string? sectionsAny = null;
            //string? sectionsNot = null;
            //string? sectionsAll = null;
            //string? tagsAny = null;
            //string? tagsNot = null;
            //string? tagsAll = null;
            //string? teamsAny = null;
            //string? followersNot = null;
            //string? createdByAny = null;
            //string? createdByNot = null;
            //string? assignedByAny = null;
            //string? assignedByNot = null;
            //string? likedByNot = null;
            //string? commentedOnByNot = null;
            //DateOnly? dueOnBefore = null;
            //DateOnly? dueOnAfter = null;
            //DateOnly? dueOn = null;
            //DateTime? dueAtBefore = null;
            //DateTime? dueAtAfter = null;
            //DateOnly? startOnBefore = null;
            //DateOnly? startOnAfter = null;
            //DateOnly? startOn = null;
            //DateOnly? createdOnBefore = null;
            //DateOnly? createdOnAfter = null;
            //DateOnly? createdOn = null;
            //DateTime? createdAtBefore = null;
            //DateTime? createdAtAfter = null;
            //DateOnly? completedOnBefore = null;
            //DateOnly? completedOnAfter = null;
            //DateOnly? completedOn = null;
            //DateTime? completedAtBefore = null;
            //DateTime? completedAtAfter = null;
            //DateOnly? modifiedOnBefore = null;
            //DateOnly? modifiedOnAfter = null;
            //DateOnly? modifiedOn = null;
            //DateTime? modifiedAtBefore = null;
            //DateTime? modifiedAtAfter = null;
            //bool? isBlocking = null;
            //bool? isBlocked = null;
            //bool? hasAttachment = null;
            //bool? completed = null;
            //bool? isSubtask = null;
            //string? sortBy = null;
            //bool? sortAscending = null;
            //List<string>? optFields = null;
            //var response = instance.SearchTasksForWorkspace(workspaceGid, optPretty, text, resourceSubtype, assigneeAny, assigneeNot, portfoliosAny, projectsAny, projectsNot, projectsAll, sectionsAny, sectionsNot, sectionsAll, tagsAny, tagsNot, tagsAll, teamsAny, followersNot, createdByAny, createdByNot, assignedByAny, assignedByNot, likedByNot, commentedOnByNot, dueOnBefore, dueOnAfter, dueOn, dueAtBefore, dueAtAfter, startOnBefore, startOnAfter, startOn, createdOnBefore, createdOnAfter, createdOn, createdAtBefore, createdAtAfter, completedOnBefore, completedOnAfter, completedOn, completedAtBefore, completedAtAfter, modifiedOnBefore, modifiedOnAfter, modifiedOn, modifiedAtBefore, modifiedAtAfter, isBlocking, isBlocked, hasAttachment, completed, isSubtask, sortBy, sortAscending, optFields);
            //Assert.IsType<SearchTasksForWorkspace200Response>(response);
        }

        /// <summary>
        /// Test SetParentForTask
        /// </summary>
        [Fact]
        public void SetParentForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //SetParentForTaskRequest setParentForTaskRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.SetParentForTask(taskGid, setParentForTaskRequest, optPretty, optFields);
            //Assert.IsType<CreateTask201Response>(response);
        }

        /// <summary>
        /// Test UpdateTask
        /// </summary>
        [Fact]
        public void UpdateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //CreateTaskRequest createTaskRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.UpdateTask(taskGid, createTaskRequest, optPretty, optFields);
            //Assert.IsType<CreateTask201Response>(response);
        }
    }
}
