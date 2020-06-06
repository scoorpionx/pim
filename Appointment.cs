class Appointment
{
    private int id {get; set;}
    private string date {get; set;}
    private string time {get; set;}
    private string status {get; set;}

    public Appointment(string date, string time) {
        this.id = 1; // Aqui será substituído por uma consulta no banco de dados
        this.date = date;
        this.time = time;
        this.status = "reserved";
    }

    public string getAppointment(int id) {
        string response = "\nData: " + this.date + "\nHora: " + this.time + "\n";
        return response;
    }
    public string updateAppointment(int id) {
        // Esse método irá atualizar o agendamento fazendo uma consulta no banco de dados
        return "";
    }
    public string finishAppointment(int id) {
        this.status = "finished";
        string response = "Finalizado!";
        return response;
    }
    public string cancelAppointment(int id) {
        this.status = "canceled";
        string response = "Cancelado!";
        return response;
    }

}