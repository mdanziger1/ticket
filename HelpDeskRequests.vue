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
                                        :items="['1 High', '2 Normal', '4 Low']"
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
                                <v-flex xs18 sm5>
                                    <v-text-field
                                        v-model="newTicket.phone"
                                        label="Phone Number"
                                        type="Number"
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

                                <v-flex xs12>
                                    <v-text-field
                                        v-model="newTicket.subject"
                                        label="Subject*"
                                        ref="newTicketSubject"
                                        :rules="[rules.required]"
                                    ></v-text-field>
                                </v-flex>
                                <v-flex xs12>
                                    <v-Textarea
                                        v-model="newTicket.description"
                                        label="Description"
                                        outline
                                        ref="newTicketDescription"
                                    ></v-Textarea>
                                </v-flex>

                                <v-btn
                                    v-if="!fileUploaded"
                                    small
                                    class="ml-0 mt-0"
                                    color="success"
                                    :loading="uploading"
                                    @click="pickFile()"
                                    >Upload Attachment</v-btn
                                >

                                <div
                                    style="border: 1px solid #4caf50; border-radius: 5px;"
                                    class="pa-2 my-3"
                                    v-if="fileUploadName.length"
                                >
                                    <v-layout
                                        row
                                        justify-space-between
                                        style="width: 350px;"
                                    >
                                        <div class="mt-0 ml-0 pt-1">
                                            {{
                                                truncateText(fileUploadName, 27)
                                            }}
                                        </div>
                                        <v-btn
                                            color="success"
                                            class="my-0 mr-1"
                                            small
                                            @click="removeUploadImg()"
                                        >
                                            remove
                                        </v-btn>
                                    </v-layout>
                                </div>
                            </v-layout>
                        </v-container>
                    </v-form>
                    <v-card-actions class="pb-3">
                        <v-spacer></v-spacer>
                        <v-btn
                            color="default"
                            @click="cencelNewTicket"
                            :dark="!cencelBtnAbility"
                            :disabled="cencelBtnAbility"
                            >Cencel</v-btn
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
        cencelBtnAbility: false,
        sendBtnDisability: false,
        title: "Help Desk Requests",
        url: "",
        actions: [],
        newTicketDialog: false,
        processing: false,
        uploading: false,
        fileUploadId: "",
        fileUploaded: false,
        fileUploadName: "",

        newTicket: {
            subject: "",
            description: "",
            category: "",
            priority: "2 Normal",
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
            if (!this.$refs.form.validate(true)) {
                return;
            }
            try {
                this.processing = true;
                this.cencelBtnAbility = true;
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

                const response = await this.$http.post(
                    "api/Manageengine/ManageenginePost",
                    {
                        User: this.$store.state.authentication.user,
                        Subject: this.newTicket.subject.trim(),
                        Description: description,
                        Priority: this.newTicket.priority,
                        Category: this.newTicket.category
                            ? this.newTicket.category
                            : "User Portal",
                        Attachments: this.fileUploadId,
                    },
                );

                this.processing = false;
                this.cencelBtnAbility = false;

                this.$notify({
                    text: "Ticket Created",
                    group: "notification",
                    type: "success",
                });

                this.reset();
                this.$refs.grid.reloadGrid();
            } catch (e) {
                this.processing = false;
                this.cencelBtnAbility = false;
            }
        },
        cencelNewTicket() {
            this.reset();
        },
        reset() {
            this.newTicketDialog = false;
            this.newTicket.subject = "";
            this.newTicket.description = "";
            this.newTicket.category = "";
            this.newTicket.priority = "2 Normal";
            this.newTicket.phone = "";
            this.newTicket.room = "";
            this.newTicket.ext = "";
            this.removeUploadImg();
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
                var formData = new FormData();
                formData.append("file", files[0]);

                const response = await this.$http.post(
                    "api/Manageengine/ManageengineUpload",
                    formData,
                    {
                        headers: {
                            "Content-Type": "multipart/form-data",
                        },
                    },
                );
                this.fileUploadId = response.files[0].file_id;
                this.fileUploadName = response.files[0].name;
                this.fileUploaded = true;
                this.uploading = false;
                this.sendBtnDisability = false;
                this.$refs.files.value = null;
            } catch (e) {
                this.uploading = false;
            }
        },
        removeUploadImg() {
            this.fileUploadId = "";
            this.fileUploaded = false;
            this.fileUploadName = "";
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
