﻿namespace Eisenhower_Matrix.Model;

public interface IToDoItemDao
{
    /// <summary>
    /// Adds a new task to the database and sets the new task ID.
    /// </summary>
    /// <param name="toDoItem">A new object, with ID not yet set (null). </param>
    public void Add(ToDoItem toDoItem);

    /// <summary>
    /// Updates existing object's data in the database.
    /// </summary>
    /// <param name="toDoItem">An object from the database, with ID already set.</param>
    public void Update(ToDoItem toDoItem);

    /// <summary>
    /// Get object by ID.
    /// </summary>
    /// <param name="id">ID to search by</param>
    /// <returns>An object with a given ID, or null if not found.</returns>
    public ToDoItem Get(int id);

    /// <summary>
    /// Delete object by ID.
    /// </summary>
    /// <param name="id">ID of the object to delete</param>
    /// <returns>True if object was found and deleted and false if not found</returns>
    public bool Delete(int id);

    /// <summary>
    /// Get all objects.
    /// </summary>
    /// <returns>List of all objects of this type in the database.</returns>
    public List<ToDoItem> GetAll();
}
