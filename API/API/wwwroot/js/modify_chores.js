async function showChores() {
    const chores = await GetAllChore();      
    //console.log(chores);
    const table = document.getElementById("modify-chore-table");
    table.innerHTML = "";                       

    for (const chore of chores) {                
        table.innerHTML += `
            <tr>
                <td><a class="row-link" href="edit_chore.html?id=${chore.id}">${chore.name}</a></td>
                <td>${chore.description}</td>
                <td>Every ${chore.howOften} days</td>
                <td> - </td>
            </tr>`;
    }

    const params = new URLSearchParams(location.search);
    const saved = params.get("saved");  
    const savedChore = chores.find(c => c.id === Number(saved));
    if(saved){
        const message = document.getElementById("saved-message");
        message.textContent = `"${savedChore.name}" was updated.`;
        message.hidden = false;
    }
}

showChores();   // run it when the page loads