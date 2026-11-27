const params = new URLSearchParams(location.search);
const id = params.get("id");

if(!id){
    location.href = "modify_chores.html";
}

async function loadChore() {
    const chore = await GetByIdChore(id);

    document.getElementById("chore-name").value = chore.name;
    document.getElementById("chore-frequency").value = chore.howOften;
    document.getElementById("chore-description").value = chore.description;
    document.getElementById("chore-points").value = chore.point;
}

loadChore();

const form = document.getElementById("edit-chore-form");

form.addEventListener("submit", async (event) => {
    event.preventDefault();
    //console.log("submit works");
    const name = document.getElementById("chore-name").value;
    const description = document.getElementById("chore-description").value;
    const howOften = Number(document.getElementById("chore-frequency").value);
    const point = Number(document.getElementById("chore-points").value);

    const chore = {
        id: Number(id),
        name: name,
        description: description,
        howOften: howOften,
        point: point,
    }
    // console.log(chore);

    const saved = await UpdateChore(chore);

    if(saved){
        location.href = `modify_chores.html?saved=${id}`;
    }
    else{
        alert("Saving failed, try again.");
    }

});

//Delete
const delete_button = document.getElementById("delete-chore");

delete_button.addEventListener("click", async () => {

    const name = document.getElementById("chore-name").value;

    const confirmation = confirm(`Delete ${name}?`);

    if(confirmation){
        const deleted = await DeleteChore(id);

        if(deleted){
            location.href = `modify_chores.html?deleted=${encodeURIComponent(name)}`;
        }
        else{
            alert("Delete attempt failed, try again.")
        }
    }
    else{
        alert("Delete attempt canceled.");
    }
});
