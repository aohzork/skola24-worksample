import axios from 'axios'

const apiClient = axios.create({
  baseURL: 'https://localhost:7285/api/v1.0/absence',
  headers: {
    'Content-Type': 'application/json'
  }
})

export default {
  getAbsenceBySchool(schoolName) {
    return apiClient.get(`/bySchool?schoolName=${schoolName}`)
  }
}
