async function GetAll() {
        const response = await fetch("/Assignment");
        const data = await response.json();
        console.log(data);
}

async function GetById(id)
{
    const response = await fetch(`/Assignment/${id}`)
    const data = await response.json();
    console.log(data)
}

async function Create(Assignment) {
    const response = await fetch("/Assignment", {
        method: "POST",
        headers: {
            "Content-Type" : "application/json"
        },
        body: JSON.stringify(Assignment)


    })

    GetAll();
}

async function Delete(id) {
    const response = await fetch(`/Assignment/${id}`, {
        method: "DELETE"
    })

    console.log("Assignment deleted succesfully")
    GetAll()
    
}


async function Update(Assignment) {
    const response = await fetch("/Assignment", {
        method: "PUT",
        headers: {
            "Content-Type" : "application/json"
        },
        body: JSON.stringify(Assignment)

    })

    console.log("Update was succesful")
    GetAll();
}







