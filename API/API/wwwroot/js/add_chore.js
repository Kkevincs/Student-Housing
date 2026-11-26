const TEMP_CREATOR_ID = 101;   // TODO: use the logged-in student when login works

const form = document.getElementById("add-chore-form");

form.addEventListener("submit", async (event) => {
    event.preventDefault();
    //console.log("submit works");
    const name = document.getElementById("chore-name").value;
    const description = document.getElementById("chore-description").value;
    const howOften = Number(document.getElementById("chore-frequency").value);
    const point = Number(document.getElementById("chore-points").value);
    const studentId = TEMP_CREATOR_ID; //TODO: change

    const chore = {
        name: name,
        description: description,
        howOften: howOften,
        point: point,
        studentId: studentId,
    }
    // console.log(chore);

    const added = await CreateChore(chore);

    if(added){
        location.href = "chore_submitted.html";
    }
    else{
        alert("Chore creation failed, try again.");
    }    
});