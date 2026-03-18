import React from 'react';

function TaskList({ tasks, updateTask, deleteTask }) {
  const toggleComplete = (task) => updateTask({ ...task, completed: !task.completed });

  return (
    <ul>
      {tasks.map(task => (
        <li key={task.id}>
          <span style={{ textDecoration: task.completed ? 'line-through' : 'none' }} onClick={() => toggleComplete(task)}>
            {task.title} [{task.priority}]
          </span>
          <button onClick={() => deleteTask(task.id)}>Delete</button>
        </li>
      ))}
    </ul>
  );
}

export default TaskList;
