import React, { useState } from 'react';

function TaskForm({ addTask }) {
  const [title, setTitle] = useState('');
  const [priority, setPriority] = useState('Medium');

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!title) return;
    addTask({ title, completed: false, priority });
    setTitle('');
    setPriority('Medium');
  };

  return (
    <form onSubmit={handleSubmit}>
      <input type="text" placeholder="New task..." value={title} onChange={e => setTitle(e.target.value)} />
      <select value={priority} onChange={e => setPriority(e.target.value)}>
        <option>High</option>
        <option>Medium</option>
        <option>Low</option>
      </select>
      <button type="submit">Add Task</button>
    </form>
  );
}

export default TaskForm;
