async function GetAllAssignment() {
        const response = await fetch("/Assignment");
        const data = await response.json();
        console.log(data);
}

async function GetByIdAssignment(id)
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

async function DeleteAssignment(id) {
    const response = await fetch(`/Assignment/${id}`, {
        method: "DELETE"
    })

    console.log("Assignment deleted succesfully")
    GetAll()
    
}


async function UpdateAssignment(Assignment) {
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








async function GetAllChore() {
    const response = await fetch("/Chore");
    const data = await response.json();
    console.log(data);
}

async function GetByIdChore(id) {
    const response = await fetch(`/Chore/${id}`)
    const data = await response.json();
    console.log(data)
}

async function CreateChore(Chore) {
    const response = await fetch("/Chore", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(Chore)


    })

    GetAll();
}

async function DeleteChore(id) {
    const response = await fetch(`/Chore/${id}`, {
        method: "DELETE"
    })

    console.log("Chore deleted succesfully")
    GetAll()

}


async function UpdateChore(Chore) {
    const response = await fetch("/Chore", {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(Chore)

    })

    console.log("Update was succesful")
    GetAll();
}










async function GetAllHouse() {
    const response = await fetch("/House");
    const data = await response.json();
    console.log(data);
}

async function GetByIdHouse(id) {
    const response = await fetch(`/House/${id}`)
    const data = await response.json();
    console.log(data)
}

async function CreateHouse(House) {
    const response = await fetch("/House", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(House)


    })

    GetAll();
}

async function DeleteHouse(id) {
    const response = await fetch(`/House/${id}`, {
        method: "DELETE"
    })

    console.log("House deleted succesfully")
    GetAll()

}


async function UpdateHouse(House) {
    const response = await fetch("/House", {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(HOuse)

    })

    console.log("Update was succesful")
    GetAll();





    async function GetAllLocation() {
        const response = await fetch("/Location");
        const data = await response.json();
        console.log(data);
    }

    async function GetByIdLocation(id) {
        const response = await fetch(`/Location/${id}`)
        const data = await response.json();
        console.log(data)
    }

    async function CreateLocation(Location) {
        const response = await fetch("/Location", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(Location)


        })

        GetAll();
    }

    async function DeleteLocation(id) {
        const response = await fetch(`/Location/${id}`, {
            method: "DELETE"
        })

        console.log("Location deleted succesfully")
        GetAll()

    }


    async function UpdateLocation(Location) {
        const response = await fetch("/Location", {
            method: "PUT",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(Location)

        })

        console.log("Update was succesful")
        GetAll();






        async function GetAllRoom() {
            const response = await fetch("/Room");
            const data = await response.json();
            console.log(data);
        }

        async function GetByIdRoom(id) {
            const response = await fetch(`/Room/${id}`)
            const data = await response.json();
            console.log(data)
        }

        async function CreateRoom(Room) {
            const response = await fetch("/Room", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(Room)


            })

            GetAll();
        }

        async function DeleteRoom(id) {
            const response = await fetch(`/Room/${id}`, {
                method: "DELETE"
            })

            console.log("Room deleted succesfully")
            GetAll()

        }


        async function UpdateRoom(Room) {
            const response = await fetch("/Room", {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(Room)

            })

            console.log("Update was succesful")
            GetAll();







            async function GetAllScore() {
                const response = await fetch("/Score");
                const data = await response.json();
                console.log(data);
            }

            async function GetByIdScore(id) {
                const response = await fetch(`/Score/${id}`)
                const data = await response.json();
                console.log(data)
            }

            async function CreateScore(Score) {
                const response = await fetch("/Score", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(Score)


                })

                GetAll();
            }

            async function DeleteScore(id) {
                const response = await fetch(`/Score/${id}`, {
                    method: "DELETE"
                })

                console.log("Score deleted succesfully")
                GetAll()

            }


            async function UpdateScore(Score) {
                const response = await fetch("/Score", {
                    method: "PUT",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(Score)

                })

                console.log("Update was succesful")
                GetAll();







                async function GetAllStudent() {
                    const response = await fetch("/Student");
                    const data = await response.json();
                    console.log(data);
                }

                async function GetByIdStudent(id) {
                    const response = await fetch(`/Student/${id}`)
                    const data = await response.json();
                    console.log(data)
                }

                async function CreateStudent(Student) {
                    const response = await fetch("/Student", {
                        method: "POST",
                        headers: {
                            "Content-Type": "application/json"
                        },
                        body: JSON.stringify(Student)


                    })

                    GetAll();
                }

                async function DeleteStudent(id) {
                    const response = await fetch(`/Student/${id}`, {
                        method: "DELETE"
                    })

                    console.log("Student deleted succesfully")
                    GetAll()

                }


                async function UpdateStudent(Student) {
                    const response = await fetch("/Student", {
                        method: "PUT",
                        headers: {
                            "Content-Type": "application/json"
                        },
                        body: JSON.stringify(Student)

                    })

                    console.log("Update was succesful")
                    GetAll();