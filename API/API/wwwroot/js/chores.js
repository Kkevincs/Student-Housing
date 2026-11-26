function howOftenText(days) {
    if (days === 1) {
        return "Every day";
    }
    else if(days === 7){
        return "Every week";
    }
    else if(days === 14){
        return "Every 2 weeks";
    }
    else if(days === 30){
        return "Every month";
    }
    return `Every ${days} days`;   // fallback for any other number
}

async function showChores() {
    const chores = await GetAllChore();  
    const assignments = await GetAllAssignment();
    const students = await GetAllStudent();

    const table = document.getElementById("chore-table");
    table.innerHTML = "";                       

    for (const chore of chores) {
        
        const choreAssignment = assignments.filter(a => a.choreId === chore.id);
        const names = choreAssignment.map(a => {
            const student = students.find(n => n.id === a.studentId);
            const firstName = student.firstName;
            return firstName;
        });
        const assignedTo = names.length !== 0 ? names.join(', ') : "Nobody";

        const status = choreAssignment.map(a => a.done ? "Done": "To Do");
        const choreStatus = status.length!== 0 ? status.join(', ') : "-";
        table.innerHTML += `
            <tr>
                <td><a class="row-link" href="edit_chore.html?id=${chore.id}">${chore.name}</a></td>
                <td>${howOftenText(chore.howOften)}</td>
                <td>${assignedTo}</td>
                <td>${choreStatus}</td>
                <td> - </td>    
            </tr>`;
    }
}

showChores();