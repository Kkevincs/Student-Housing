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