import { absenceReasons, absences } from './data'

export function getFullStudentData() {
  const result = absences.map((abs) => {
    const matchedReason = absenceReasons.find((reasons) => reasons.guid === abs.reasonGuid)

    return {
      id: abs.id,
      name: `${abs.firstName} ${abs.lastName}`,
      dateFrom: abs.dateTimeFrom,
      dateTo: abs.dateTimeTo ? abs.dateTimeTo : undefined,
      reason: abs.reasonGuid ? matchedReason.id : undefined
    }
  })

  return result
}

export function getRandomStudent() {
  const students = getFullStudentData()

  const rndIndex = Math.floor(Math.random() * students.length)

  const rndStudent = students[rndIndex]
  return rndStudent
}
