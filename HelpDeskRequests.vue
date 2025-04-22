<template>
    <div>
        <dx-grid
            :url="url"
            :columns="columns"
            :title="title"
            :beforeSetupGrid="beforeSetupGrid"
            :actions="actions"
            ref="grid"
            navigationPath="HelpDeskRequestView"
            navigationField="id"
        ></dx-grid>

        <v-layout row justify-center>
            <v-dialog persistent v-model="newTicketDialog" max-width="800">
                <v-card>
                    <v-card-title>
                        <span class="headline">New request</span>
                    </v-card-title>
                    <v-form ref="form">
                        <v-container grid-list-md>
                            <v-layout wrap>
                                <v-flex xs12 sm6>
                                    <v-select
                                        v-model="newTicket.priority"
                                        :items="['High', 'Normal', 'Low']"
                                        label="Priority"
                                        ref="newTicketSelectedPriority"
                                        :rules="[rules.required]"
                                    ></v-select>
                                </v-flex>
                                <v-flex xs12 sm6>
                                    <v-select
                                        v-model="newTicket.category"
                                        :items="[
                                            'Telephone',
                                            'Desktop / Laptop /Server',
                                            'Printers / scanner / Fax',
                                            'Software',
                                            'Camera',
                                        ]"
                                        label="Category"
                                        ref="newTicketCategory"
                                    ></v-select>
                                </v-flex>

                                <v-flex xs12>
                                    <v-text-field
                                        v-model="newTicket.subject"
                                        label="Enter a brief title for your request"
                                        ref="newTicketSubject"
                                        :rules="[rules.required]"
                                    ></v-text-field>
                                </v-flex>
                                <v-flex xs12>
                                    <v-Textarea
                                        v-model="newTicket.description"
                                        label="Write a message"
                                        outline
                                        ref="newTicketDescription"
                                    ></v-Textarea>
                                </v-flex>

                                <v-flex xs12>
                                    <span
                                        >This information is optional but
                                        recommended:</span
                                    >
                                </v-flex>
                                <v-flex xs18 sm5>
                                    <v-text-field
                                        v-model="newTicket.phone"
                                        label="Phone Number"
                                    ></v-text-field>
                                </v-flex>
                                <v-flex xs18 sm3>
                                    <v-text-field
                                        v-model="newTicket.room"
                                        label="Room Number"
                                    ></v-text-field>
                                </v-flex>
                                <v-flex xs18 sm3>
                                    <v-text-field
                                        v-model="newTicket.ext"
                                        label="Ext Number"
                                    ></v-text-field>
                                </v-flex>
                                <v-flex xs18 sm8>
                                    <v-btn
                                        small
                                        class="ml-0 mt-0"
                                        color="success"
                                        :loading="uploading"
                                        @click="pickFile()"
                                        >Upload Attachment</v-btn
                                    >
                                </v-flex>
                                <v-card
                                    v-for="(file, index) in fileUploadList"
                                    style="border: 1px solid #4caf50; border-radius: 5px; margin-right: 10px;"
                                    class="pa-2 my-2"
                                >
                                    <v-layout
                                        row
                                        justify-space-between
                                        style="width: 250px;"
                                    >
                                        <div class="mt-0 ml-0 pt-1">
                                            {{ truncateText(file.name, 18) }}
                                        </div>
                                        <v-btn
                                            color="success"
                                            class="my-0 mr-1"
                                            small
                                            @click="removeUploadImg(index)"
                                        >
                                            remove
                                        </v-btn>
                                    </v-layout>
                                </v-card>
                            </v-layout>
                        </v-container>
                    </v-form>
                    <v-card-actions class="pb-3">
                        <v-spacer></v-spacer>
                        <v-btn
                            color="default"
                            @click="cancelNewTicket"
                            :dark="!cancelBtnAbility"
                            :disabled="cancelBtnAbility"
                            >Cancel</v-btn
                        >
                        <v-btn
                            :loading="processing"
                            dark
                            color="success"
                            @click="saveNewTicket"
                            :dark="!sendBtnDisability"
                            :disabled="sendBtnDisability"
                            >Send</v-btn
                        >
                        <input
                            type="file"
                            multiple
                            style="display: none"
                            ref="files"
                            @change="onFilePicked($event)"
                        />
                    </v-card-actions>
                </v-card>
            </v-dialog>
        </v-layout>
    </div>
</template>

<script>
import moment from "moment";
import { formatCurrency } from "../../utils/helpers.js";
import { truncate } from "../../utils/helpers.js";
export default {
    data: () => ({
        cancelBtnAbility: false,
        sendBtnDisability: false,
        title: "Help Desk Requests",
        url: "",
        actions: [],
        newTicketDialog: false,
        processing: false,
        uploading: false,
        fileUploadList: [],

        newTicket: {
            subject: "",
            description: "",
            category: "",
            priority: "Normal",
            phone: "",
            room: "",
            ext: "",
        },

        rules: {
            required: (value) => !!value || "Required.",
        },

        columns: [
            {
                field: "statusIcon",
                isIcon: true,
                template: "icon",
                alignment: "center",
                visible: true,
                allowFiltering: false,
                allowHeaderFiltering: false,
                allowHiding: false,
                allowSearch: false,
                cssClass: "width-25",
                headerFilter: {
                    allowSearch: false,
                    groupInterval: undefined,
                    height: undefined,
                    searchMode: "contains",
                },
                icon: (value) => {
                    switch (value) {
                        case "Closed":
                            return "mdi-check-circle";
                        case "Open":
                            return "mdi-clock";
                        default:
                            return "";
                    }
                },
                iconColor: (value) => {
                    switch (value) {
                        case "Closed":
                            return "success";
                        case "Open":
                            return "#fdb400";
                        default:
                            return "#aeb8bf";
                    }
                },
            },
            {
                label: "Ticket Number",
                field: "displayID",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            {
                label: "Name",
                field: "name",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            {
                label: "Requester Email",
                field: "requesterEmail",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            {
                label: "Created At",
                field: "createdAt",
                visible: true,
                type: "date",
                format: "MM/dd/yyyy hh:mm:ss a",
                sortOrder: "desc",
                sortIndex: 0,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            {
                label: "Site",
                field: "siteName",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            {
                label: "Status",
                field: "statusName",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            {
                label: "Subject",
                field: "subject",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            {
                label: "Department",
                field: "departmentName",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
            // {
            //     label: "Technician Email",
            //     field: "technicianEmail",
            //     visible: true,
            //     filterValues: [],
            //     filterValue: null,
            //     selectedFilterOperation: null,
            // },
            {
                label: "Technician",
                field: "technicianName",
                visible: true,
                filterValues: [],
                filterValue: null,
                selectedFilterOperation: null,
            },
        ],
    }),
    created() {
        if (this.isAdmin()) {
            this.actions.push({
                text: "Filter for " + this.$store.state.authentication.user,
                type: "switch",
                action: this.onUserFilterChanged,
            });
        }

        this.actions.push({
            text: "New Ticket",
            action: this.openNewTicket,
        });
    },

    methods: {
        async beforeSetupGrid() {
            this.url =
                "manageengine?user=" +
                (this.isAdmin() ? "" : this.$store.state.authentication.user);
        },
        async onRowClicked(row) {},
        isAdmin() {
            const isAdmin = this.$store.getters["authentication/isAdmin"];

            if (!isAdmin || isAdmin == "false") return false;

            return true;
        },
        onUserFilterChanged(value) {
            if (value) {
                this.url =
                    "manageengine?user=" +
                    this.$store.state.authentication.user;
            } else {
                this.url = "manageengine?user=";
            }

            this.$refs.grid.reloadDataSource(this.url);
        },
        async openNewTicket() {
            this.newTicketDialog = true;

            this.$refs.form.resetValidation(true);
        },
        async saveNewTicket() {
            const filesId = [];
            for (var i = 0; i < this.fileUploadList.length; i++) {
                filesId.push(this.fileUploadList[i].file_id);
            }
            if (!this.$refs.form.validate(true)) {
                return;
            }
            try {
                this.processing = true;
                this.cancelBtnAbility = true;
                const hasUserInfo =
                    this.newTicket.phone ||
                    this.newTicket.room.trim() ||
                    this.newTicket.ext.trim();

                const userInfo = [
                    this.newTicket.phone
                        ? ` Phone = ${this.newTicket.phone}`
                        : "",
                    this.newTicket.room.trim()
                        ? ` Room = ${this.newTicket.room.trim()}`
                        : "",
                    this.newTicket.ext.trim()
                        ? ` Ext = ${this.newTicket.ext.trim()} `
                        : "",
                ]
                    .filter(Boolean)
                    .join(", ");

                const description = `${this.newTicket.description.trim()}${
                    hasUserInfo ? ` (User Info: ${userInfo})` : ""
                }`;

                const priorityMap = {
                    High: "1 High",
                    Normal: "2 Normal",
                    Low: "4 Low",
                };

                const response = await this.$http.post(
                    "api/Manageengine/ManageenginePost",
                    {
                        User: this.$store.state.authentication.user,
                        Subject: this.newTicket.subject.trim(),
                        Description: description,
                        Priority: priorityMap[this.newTicket.priority],
                        Category: this.newTicket.category
                            ? this.newTicket.category
                            : "User Portal",
                        Attachments: filesId[0] ? JSON.stringify(filesId) : "",
                    },
                );

                this.processing = false;
                this.cancelBtnAbility = false;

                this.$notify({
                    text: "Ticket Created",
                    group: "notification",
                    type: "success",
                });

                this.reset();
                this.$refs.grid.reloadGrid();
            } catch (e) {
                this.processing = false;
                this.cancelBtnAbility = false;
            }
        },
        cancelNewTicket() {
            this.reset();
        },
        reset() {
            this.newTicketDialog = false;
            this.newTicket.subject = "";
            this.newTicket.description = "";
            this.newTicket.category = "";
            this.newTicket.priority = "Normal";
            this.newTicket.phone = "";
            this.newTicket.room = "";
            this.newTicket.ext = "";
            this.removeAllUploadImg();
        },
        pickFile() {
            this.$refs.files.click();
        },
        async onFilePicked(e) {
            this.uploading = true;
            this.sendBtnDisability = true;
            const files = e.target.files;

            if (!files) return;
            try {
                for (var i = 0; i < files.length; i++) {
                    var formData = new FormData();
                    formData.append("file", files[i]);
                    const response = await this.$http.post(
                        "api/Manageengine/ManageengineUpload",
                        formData,
                        {
                            headers: {
                                "Content-Type": "multipart/form-data",
                            },
                        },
                    );
                    this.fileUploadList.push(response.files[0]);
                }
                this.uploading = false;
                this.sendBtnDisability = false;
                this.$refs.files.value = null;
            } catch (e) {
                this.uploading = false;
            }
        },
        removeUploadImg(index) {
            this.fileUploadList.splice(index, 1);
        },
        removeAllUploadImg() {
            this.fileUploadList = [];
            this.uploading = false;
            this.sendBtnDisability = false;
            this.$refs.files.value = null;
        },

        truncateText(text, count = 25) {
            return truncate(text, count);
        },
    },
};
</script>
<style></style>
