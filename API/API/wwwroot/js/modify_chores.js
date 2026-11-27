async function showChores() {
    const chores = await GetAllChore();      
    //console.log(chores);
    const table = document.getElementById("modify-chore-table");
    table.innerHTML = "";                       

    for (const chore of chores) {                
        table.innerHTML += `
            <tr data-id="${chore.id}">
                <td><a class="row-link" href="edit_chore.html?id=${chore.id}">${chore.name}</a></td>
                <td>${chore.description}</td>
                <td>Every ${chore.howOften} days</td>
                <td> - </td>
            </tr>`;
    }

    table.addEventListener("click", (event) => {
        const row = event.target.closest("tr");
        if (!row) {
            return;
        }
        location.href = `edit_chore.html?id=${row.dataset.id}`;
    });

    const params = new URLSearchParams(location.search);
    const saved = params.get("saved");  
    const savedChore = chores.find(c => c.id === Number(saved));
    if(saved && savedChore){
        const message = document.getElementById("saved-message");
        message.textContent = `"${savedChore.name}" was updated.`;
        message.hidden = false;
    }

    const deleted = params.get("deleted");      
    if(deleted){
        const message = document.getElementById("deleted-message");
        message.textContent = `"${deleted}" was deleted.`;
        message.hidden = false;
    }
}

showChores();   // run it when the page loads